using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblSupplierState
{
    public int SupSupplierId { get; set; }

    public string StaStateId { get; set; } = null!;

    public int ShiMetShippingMethodId { get; set; }

    public virtual TblState StaState { get; set; } = null!;
}
