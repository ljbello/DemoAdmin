using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SummedMismatch
{
    public string? Order { get; set; }

    public string? AuthorizeName { get; set; }

    public decimal? AuthorizeAmount { get; set; }

    public string? CustomerName { get; set; }

    public decimal? SettlementAmount { get; set; }
}
