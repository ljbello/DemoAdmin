using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class DiscountGroup
{
    public int DiscountGroupId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int StoreId { get; set; }

    public bool Active { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<DiscountGroupProductType> DiscountGroupProductTypes { get; set; } = new List<DiscountGroupProductType>();

    public virtual ICollection<DiscountGroupQuantity> DiscountGroupQuantities { get; set; } = new List<DiscountGroupQuantity>();

    public virtual ICollection<DiscountGroupSchedule> DiscountGroupSchedules { get; set; } = new List<DiscountGroupSchedule>();

    public virtual Store Store { get; set; } = null!;
}
