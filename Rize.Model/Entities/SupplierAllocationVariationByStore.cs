using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierAllocationVariationByStore
{
    public int SupplierAllocationVariationByStoreId { get; set; }

    public int StoreId { get; set; }

    public int VariationId { get; set; }

    public long SupplierId { get; set; }
}
