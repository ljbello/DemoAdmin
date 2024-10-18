using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VariationPricingGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int ProductTypeId { get; set; }

    public int StoreId { get; set; }

    public bool IsDefault { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public bool Active { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual ProductType ProductType { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;

    public virtual ICollection<VariationPriceGroupQuantity> VariationPriceGroupQuantities { get; set; } = new List<VariationPriceGroupQuantity>();
}
