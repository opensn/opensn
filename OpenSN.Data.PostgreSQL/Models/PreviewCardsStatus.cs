using System;
using System.Collections.Generic;

namespace OpenSN.Data.PostgreSQL.Models;

public partial class PreviewCardsStatus
{
    public long PreviewCardId { get; set; }

    public long StatusId { get; set; }
}
