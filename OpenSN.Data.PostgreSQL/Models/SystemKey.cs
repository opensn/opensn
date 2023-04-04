using System;
using System.Collections.Generic;

namespace OpenSN.Data.PostgreSQL.Models;

public partial class SystemKey
{
    public long Id { get; set; }

    public byte[]? Key { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
