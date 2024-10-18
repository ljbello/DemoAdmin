using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblShippingMethod
{
    public int ShiMetShippingMethodId { get; set; }

    public string ShiMetStrDescription { get; set; } = null!;

    public int ShiMetDisplaySequence { get; set; }

    public string? Abb { get; set; }

    public virtual ICollection<StoreShippingMethod> StoreShippingMethods { get; set; } = new List<StoreShippingMethod>();

    public virtual ICollection<SupplierStatusShippingCodeCrossRef> SupplierStatusShippingCodeCrossRefs { get; set; } = new List<SupplierStatusShippingCodeCrossRef>();

    public virtual ICollection<TblOrderLineStatus> TblOrderLineStatuses { get; set; } = new List<TblOrderLineStatus>();

    public virtual ICollection<TblOrderLine> TblOrderLines { get; set; } = new List<TblOrderLine>();
}
