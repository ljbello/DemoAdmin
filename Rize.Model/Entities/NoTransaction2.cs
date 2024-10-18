using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class NoTransaction2
{
    public int Order { get; set; }

    public string? CustomerName { get; set; }

    public decimal? SettlementAmount { get; set; }

    public bool? WaitingOnCheck { get; set; }

    public string? CheckNumber { get; set; }

    public decimal? CheckAmount { get; set; }

    public DateTime? CheckReceivedDate { get; set; }

    public string? OrderNotes { get; set; }

    public string? OrdStaDescription { get; set; }

    public string? InvoiceNumber { get; set; }

    public string TransactionId { get; set; } = null!;
}
