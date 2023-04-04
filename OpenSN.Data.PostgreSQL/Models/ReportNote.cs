﻿using System;
using System.Collections.Generic;

namespace OpenSN.Data.PostgreSQL.Models;

public partial class ReportNote
{
    public long Id { get; set; }

    public string Content { get; set; } = null!;

    public long ReportId { get; set; }

    public long AccountId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual Report Report { get; set; } = null!;
}
