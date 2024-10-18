using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VSupplierOrderShippingMethod
{
    public int SupplierShippingCodeId { get; set; }

    public int SupplierId { get; set; }

    public string SupplierShippingCode { get; set; } = null!;

    public int ShippingMethodId { get; set; }

    public string ShiMetStrDescription { get; set; } = null!;

    public int ShippingCarrierId { get; set; }

    public string ShiCarDescription { get; set; } = null!;
}
