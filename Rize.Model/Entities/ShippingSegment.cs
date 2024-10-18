using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ShippingSegment
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public virtual TblUser? CreatedByNavigation { get; set; }

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual ICollection<ShippingGroupSegmentMethod> ShippingGroupSegmentMethods { get; set; } = new List<ShippingGroupSegmentMethod>();

    public virtual ICollection<ShippingSegmentDetail> ShippingSegmentDetails { get; set; } = new List<ShippingSegmentDetail>();
}
