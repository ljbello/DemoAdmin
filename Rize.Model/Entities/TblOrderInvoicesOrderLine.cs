using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrderInvoicesOrderLine
{
    public Guid OrdInvOrdLinOrderInvoiceOrderLineId { get; set; }

    public Guid? OrdInvOrderInvoiceId { get; set; }

    public int? OrdLinOrderLineId { get; set; }

    public string? OrdInvOrdLinDescription { get; set; }

    public int? OrdInvOrdLinQuantity { get; set; }

    public decimal? OrdInvOrdLinUnitPrice { get; set; }

    public decimal? OrdInvOrdLinSubtotal { get; set; }

    public string? OrdInvOrdLinSupplierPartId { get; set; }

    public virtual TblOrderInvoice? OrdInvOrderInvoice { get; set; }
}
