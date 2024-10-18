using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblAmountMisMatch
{
    public int Order { get; set; }

    public string CustomerName { get; set; } = null!;

    public decimal SettlementAmount { get; set; }

    public decimal AuthorizeAmount { get; set; }
}
