using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrderMailedInvoice
{
    public int OrdMaiInvOrderMailedInvoiceId { get; set; }

    public int OrdOrderId { get; set; }

    public decimal? OrdMaiInvAmountDue { get; set; }

    public DateTime DateCreated { get; set; }

    public string? RequestId { get; set; }

    public virtual Order OrdOrder { get; set; } = null!;
}
