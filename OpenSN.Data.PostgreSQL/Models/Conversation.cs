﻿using System;
using System.Collections.Generic;

namespace OpenSN.Data.PostgreSQL.Models;

public partial class Conversation
{
    public long Id { get; set; }

    public string? Uri { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<AccountConversation> AccountConversations { get; } = new List<AccountConversation>();

    public virtual ICollection<ConversationMute> ConversationMutes { get; } = new List<ConversationMute>();
}
