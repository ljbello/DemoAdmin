using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ShippingGroupSegmentMethod
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int MethodId { get; set; }

    public int SegmentId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public virtual ShippingGroup Group { get; set; } = null!;

    public virtual ShippingSegment Segment { get; set; } = null!;
}
