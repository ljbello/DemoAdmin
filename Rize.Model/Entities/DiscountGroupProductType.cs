using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class DiscountGroupProductType
{
    public int DiscountGroupProductTypeId { get; set; }

    public int DiscountGroupId { get; set; }

    public int ProductTypeId { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual DiscountGroup DiscountGroup { get; set; } = null!;

    public virtual ProductType ProductType { get; set; } = null!;
}
