using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductOptionType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string FriendlyName { get; set; } = null!;

    public int Sequence { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public bool Active { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<ProductOptionPriceGroup> ProductOptionPriceGroups { get; set; } = new List<ProductOptionPriceGroup>();
}
