﻿using System;
using System.Collections.Generic;

namespace OpenSN.Data.PostgreSQL.Models;

public partial class Import
{
    public int Type { get; set; }

    public bool Approved { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? DataFileName { get; set; }

    public string? DataContentType { get; set; }

    public long? DataFileSize { get; set; }

    public DateTime? DataUpdatedAt { get; set; }

    public long AccountId { get; set; }

    public long Id { get; set; }

    public bool Overwrite { get; set; }

    public virtual Account Account { get; set; } = null!;
}
