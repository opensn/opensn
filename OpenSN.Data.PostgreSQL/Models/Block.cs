﻿using System;
using System.Collections.Generic;

namespace OpenSN.Data.PostgreSQL.Models;

public partial class Block
{
    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public long AccountId { get; set; }

    public long Id { get; set; }

    public long TargetAccountId { get; set; }

    public string? Uri { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual Account TargetAccount { get; set; } = null!;
}
