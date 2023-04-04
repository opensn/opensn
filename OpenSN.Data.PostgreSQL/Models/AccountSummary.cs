using System;
using System.Collections.Generic;

namespace OpenSN.Data.PostgreSQL.Models;

public partial class AccountSummary
{
    public long? AccountId { get; set; }

    public string? Language { get; set; }

    public bool? Sensitive { get; set; }
}
