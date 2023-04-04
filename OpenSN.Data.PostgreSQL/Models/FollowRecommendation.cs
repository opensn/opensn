﻿using System;
using System.Collections.Generic;

namespace OpenSN.Data.PostgreSQL.Models;

public partial class FollowRecommendation
{
    public long? AccountId { get; set; }

    public decimal? Rank { get; set; }

    public string[]? Reason { get; set; }
}
