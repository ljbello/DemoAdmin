using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblSupplierProductsStock
{
    public string ProSupplierProductNumber { get; set; } = null!;

    public int SupSupplierId { get; set; }

    public string? SupProStockNumber { get; set; }

    public int? SupProQuanityOnHand { get; set; }

    public int? SupProQuanityCommitted { get; set; }

    public DateTime? SupProDateCreated { get; set; }

    public string? SupProRequestedBy { get; set; }

    public Guid Rowguid { get; set; }

    public int? InFlightQuantity { get; set; }

    public virtual TblSupplier SupSupplier { get; set; } = null!;
}
