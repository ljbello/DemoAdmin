using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierAllocationDefaultSupplierByZip
{
    public string? Zip3 { get; set; }

    public int DefaultSupplierId { get; set; }
}
