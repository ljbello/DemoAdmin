using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierCardSizeMapping
{
    public int SupplierCardSizeMappingId { get; set; }

    public int CardSizeId { get; set; }

    public int SupplierId { get; set; }

    public virtual CardSize CardSize { get; set; } = null!;

    public virtual TblSupplier Supplier { get; set; } = null!;
}
