using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblAuthorizationTransactionType
{
    public string AutTraTypAuthorizationTransactionTypeId { get; set; } = null!;

    public string AutTraTypDescription { get; set; } = null!;

    public int AutTraTypSequence { get; set; }
}
