﻿using System;
using System.Collections.Generic;

namespace OpenSN.Data.PostgreSQL.Models;

public partial class Webhook
{
    public long Id { get; set; }

    public string Url { get; set; } = null!;

    public string[] Events { get; set; } = null!;

    public string Secret { get; set; } = null!;

    public bool? Enabled { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
