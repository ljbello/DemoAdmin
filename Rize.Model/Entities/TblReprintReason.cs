using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblReprintReason
{
    public int RepReaReprintReasonId { get; set; }

    public string RepReaDescription { get; set; } = null!;

    public int RepReaSequence { get; set; }

    public string? SearchLookup { get; set; }

    public string? SupplierErrorCode { get; set; }

    public string? DefaultFaultType { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<TblOrderLine> TblOrderLines { get; set; } = new List<TblOrderLine>();
}
