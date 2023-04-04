﻿using System;
using System.Collections.Generic;
using System.Net;

namespace OpenSN.Data.PostgreSQL.Models;

public partial class User
{
    public string Email { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string EncryptedPassword { get; set; } = null!;

    public string? ResetPasswordToken { get; set; }

    public DateTime? ResetPasswordSentAt { get; set; }

    public int SignInCount { get; set; }

    public DateTime? CurrentSignInAt { get; set; }

    public DateTime? LastSignInAt { get; set; }

    public bool Admin { get; set; }

    public string? ConfirmationToken { get; set; }

    public DateTime? ConfirmedAt { get; set; }

    public DateTime? ConfirmationSentAt { get; set; }

    public string? UnconfirmedEmail { get; set; }

    public string? Locale { get; set; }

    public string? EncryptedOtpSecret { get; set; }

    public string? EncryptedOtpSecretIv { get; set; }

    public string? EncryptedOtpSecretSalt { get; set; }

    public int? ConsumedTimestep { get; set; }

    public bool OtpRequiredForLogin { get; set; }

    public DateTime? LastEmailedAt { get; set; }

    public string[]? OtpBackupCodes { get; set; }

    public long AccountId { get; set; }

    public long Id { get; set; }

    public bool Disabled { get; set; }

    public bool Moderator { get; set; }

    public long? InviteId { get; set; }

    public string[]? ChosenLanguages { get; set; }

    public long? CreatedByApplicationId { get; set; }

    public bool? Approved { get; set; }

    public string? SignInToken { get; set; }

    public DateTime? SignInTokenSentAt { get; set; }

    public string? WebauthnId { get; set; }

    public IPAddress? SignUpIp { get; set; }

    public bool? SkipSignInToken { get; set; }

    public long? RoleId { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual ICollection<Backup> Backups { get; } = new List<Backup>();

    public virtual OauthApplication? CreatedByApplication { get; set; }

    public virtual ICollection<Identity> Identities { get; } = new List<Identity>();

    public virtual Invite? Invite { get; set; }

    public virtual ICollection<Invite> Invites { get; } = new List<Invite>();

    public virtual ICollection<LoginActivity> LoginActivities { get; } = new List<LoginActivity>();

    public virtual ICollection<Marker> Markers { get; } = new List<Marker>();

    public virtual ICollection<OauthAccessGrant> OauthAccessGrants { get; } = new List<OauthAccessGrant>();

    public virtual ICollection<OauthAccessToken> OauthAccessTokens { get; } = new List<OauthAccessToken>();

    public virtual ICollection<OauthApplication> OauthApplications { get; } = new List<OauthApplication>();

    public virtual UserRole? Role { get; set; }

    public virtual ICollection<SessionActivation> SessionActivations { get; } = new List<SessionActivation>();

    public virtual ICollection<UserInviteRequest> UserInviteRequests { get; } = new List<UserInviteRequest>();

    public virtual ICollection<WebPushSubscription> WebPushSubscriptions { get; } = new List<WebPushSubscription>();

    public virtual WebSetting? WebSetting { get; set; }

    public virtual ICollection<WebauthnCredential> WebauthnCredentials { get; } = new List<WebauthnCredential>();
}
