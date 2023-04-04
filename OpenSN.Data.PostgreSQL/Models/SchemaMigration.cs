using System;
using System.Collections.Generic;

namespace OpenSN.Data.PostgreSQL.Models;

public partial class SchemaMigration
{
    public string Version { get; set; } = null!;
}
