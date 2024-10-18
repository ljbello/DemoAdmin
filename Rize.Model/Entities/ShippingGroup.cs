using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ShippingGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public int StoreId { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<ShippingGroupSegmentMethod> ShippingGroupSegmentMethods { get; set; } = new List<ShippingGroupSegmentMethod>();

    public virtual Store Store { get; set; } = null!;

    public virtual ICollection<VariationShippingGroup> VariationShippingGroups { get; set; } = new List<VariationShippingGroup>();
}
