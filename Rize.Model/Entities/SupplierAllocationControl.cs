using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierAllocationControl
{
    public int SupplierId { get; set; }

    public string SupplierName { get; set; } = null!;

    public bool EnabledforAllocation { get; set; }

    public DateTime CreateDate { get; set; }

    public bool? SkipLevelDpallocation { get; set; }

    public bool? VariableAddressEnabled { get; set; }
}
