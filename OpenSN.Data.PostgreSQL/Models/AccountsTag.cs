﻿using System;
using System.Collections.Generic;

namespace OpenSN.Data.PostgreSQL.Models;

public partial class AccountsTag
{
    public long AccountId { get; set; }

    public long TagId { get; set; }
}
