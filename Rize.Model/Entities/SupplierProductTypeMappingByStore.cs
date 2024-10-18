using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierProductTypeMappingByStore
{
    public int SupplierProductTypeMappingByStoreId { get; set; }

    public int? ProductTypeId { get; set; }

    public int? SupplierId { get; set; }

    public int? StoreId { get; set; }
}
