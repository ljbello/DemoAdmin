using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierProductMapping
{
    public int SupplierProductMappingId { get; set; }

    public int ProductId { get; set; }

    public int SupplierId { get; set; }

    public bool? SaveRecord { get; set; }

    public virtual TblProduct Product { get; set; } = null!;

    public virtual TblSupplier Supplier { get; set; } = null!;
}
