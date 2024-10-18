using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblShippingCarrier
{
    public int ShiCarShippingCarrierId { get; set; }

    public string ShiCarDescription { get; set; } = null!;

    public string? ShiCarTrackingUrlwithPlaceholders { get; set; }

    public string? GtsCarrierCode { get; set; }

    public string? GtsOtherCarrierName { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<SupplierStatusShippingCodeCrossRef> SupplierStatusShippingCodeCrossRefs { get; set; } = new List<SupplierStatusShippingCodeCrossRef>();

    public virtual ICollection<TblOrderLine> TblOrderLines { get; set; } = new List<TblOrderLine>();
}
