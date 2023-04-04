﻿using System;
using System.Collections.Generic;

namespace OpenSN.Data.PostgreSQL.Models;

public partial class DomainBlock
{
    public string Domain { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? Severity { get; set; }

    public bool RejectMedia { get; set; }

    public long Id { get; set; }

    public bool RejectReports { get; set; }

    public string? PrivateComment { get; set; }

    public string? PublicComment { get; set; }

    public bool Obfuscate { get; set; }
}
