using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ShippingSegmentDetail
{
    public int Id { get; set; }

    public int SegmentId { get; set; }

    public int Low { get; set; }

    public int High { get; set; }

    public bool Multiplier { get; set; }

    public decimal Rate { get; set; }

    public bool Active { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public virtual ShippingSegment Segment { get; set; } = null!;
}
