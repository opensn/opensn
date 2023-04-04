﻿using System;
using System.Collections.Generic;

namespace OpenSN.Data.PostgreSQL.Models;

public partial class Announcement
{
    public long Id { get; set; }

    public string Text { get; set; } = null!;

    public bool Published { get; set; }

    public bool AllDay { get; set; }

    public DateTime? ScheduledAt { get; set; }

    public DateTime? StartsAt { get; set; }

    public DateTime? EndsAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? PublishedAt { get; set; }

    public long[]? StatusIds { get; set; }

    public virtual ICollection<AnnouncementMute> AnnouncementMutes { get; } = new List<AnnouncementMute>();

    public virtual ICollection<AnnouncementReaction> AnnouncementReactions { get; } = new List<AnnouncementReaction>();
}
