using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrderInvoice
{
    public Guid OrdInvOrderInvoiceId { get; set; }

    public int OrdOrderId { get; set; }

    public int SupSupplierId { get; set; }

    public string? OrdInvInvoiceNumber { get; set; }

    public DateTime? OrdInvInvoiceDate { get; set; }

    public decimal? OrdInvInvoiceShipping { get; set; }

    public decimal? OrdInvInvoiceSubTotal { get; set; }

    public decimal? OrdInvAdditionalCreditOrDebit { get; set; }

    public string? OrdInvComments { get; set; }

    public DateTime? DateCreated { get; set; }

    public bool? OrdInvDigitalPressOrPhoto { get; set; }

    public virtual Order OrdOrder { get; set; } = null!;

    public virtual TblSupplier SupSupplier { get; set; } = null!;

    public virtual ICollection<TblOrderInvoicesOrderLine> TblOrderInvoicesOrderLines { get; set; } = new List<TblOrderInvoicesOrderLine>();
}
