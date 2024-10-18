using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierStatusShippingCodeCrossRef
{
    public int SupplierShippingCodeId { get; set; }

    public int SupplierId { get; set; }

    public string SupplierShippingCode { get; set; } = null!;

    public int ShippingMethodId { get; set; }

    public int ShippingCarrierId { get; set; }

    public virtual TblShippingCarrier ShippingCarrier { get; set; } = null!;

    public virtual TblShippingMethod ShippingMethod { get; set; } = null!;

    public virtual TblSupplier Supplier { get; set; } = null!;
}
