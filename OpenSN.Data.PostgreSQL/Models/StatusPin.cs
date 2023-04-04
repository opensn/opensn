﻿using System;
using System.Collections.Generic;

namespace OpenSN.Data.PostgreSQL.Models;

public partial class StatusPin
{
    public long Id { get; set; }

    public long AccountId { get; set; }

    public long StatusId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}
