using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblSupplierProductsStockOrdered
{
    public Guid Rowguid { get; set; }

    public string ProSupplierProductNumber { get; set; } = null!;

    public int SupSupplierId { get; set; }

    public int? SupProQuanityOnOrder { get; set; }

    public DateTime? SupProDateOrderEta { get; set; }

    public DateTime SupProDateCreated { get; set; }

    public virtual TblSupplier SupSupplier { get; set; } = null!;
}
