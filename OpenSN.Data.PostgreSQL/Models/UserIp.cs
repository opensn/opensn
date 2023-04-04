using System;
using System.Collections.Generic;
using System.Net;

namespace OpenSN.Data.PostgreSQL.Models;

public partial class UserIp
{
    public long? UserId { get; set; }

    public IPAddress? Ip { get; set; }

    public DateTime? UsedAt { get; set; }
}
