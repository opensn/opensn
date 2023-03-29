using OpenSN.Cryptography;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace OpenSN.Services;

[Authorize]
public sealed class AuthenticationService : Authentication.AuthenticationBase
{
    private readonly IConfiguration _config;
    private readonly ILogger<AuthenticationService> _logger;

    public AuthenticationService(ILogger<AuthenticationService> logger, IConfiguration config)
    {
        _logger = logger;
        _config = config;
    }

    [AllowAnonymous]
    public override Task<JsonWebToken> SignIn(SignInRequest request, ServerCallContext context)
    {
        var jwtOptions = _config.GetSection("JwtSettings").Get<JwtOptions>()!;

        var publicKeyBytes = request.PublicKey.ToArray();
        var publicKey = new PublicKey(publicKeyBytes);

        var signatureBytes = request.Signature.ToArray();
        var messageBytes = HashHelpers.SHA256(publicKeyBytes);

        var valid = Secp256K1.VerifySignature(publicKey, messageBytes, signatureBytes);

        if (!valid)
        {
            throw new RpcException(new global::Grpc.Core.Status(StatusCode.InvalidArgument, string.Empty));
        }

        var address = publicKey.ToEthereumAddress();
        var accountId = $"0x{address.ToLower()}";
        var tokenHandler = new JwtSecurityTokenHandler();

        var key = jwtOptions.SecretKey;
        var jwtkey = Encoding.UTF8.GetBytes(key);

        var expires = DateTime.UtcNow.AddYears(1);
        var jti = Guid.NewGuid().ToString();

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[] { new Claim(JwtRegisteredClaimNames.UniqueName, accountId) }),
            Claims = new Dictionary<string, object>
            {
                [JwtRegisteredClaimNames.UniqueName] = accountId,
                [JwtRegisteredClaimNames.Jti] = jti,
            },
            Expires = expires,
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(jwtkey), SecurityAlgorithms.HmacSha256Signature)
        };

        var jwttoken = tokenHandler.CreateToken(tokenDescriptor);

        var jwt = new JsonWebToken
        {
            Value = tokenHandler.WriteToken(jwttoken)
        };

        return Task.FromResult(jwt);
    }
}
