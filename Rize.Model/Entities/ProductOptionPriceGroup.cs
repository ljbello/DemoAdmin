using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductOptionPriceGroup
{
    public int Id { get; set; }

    public string ProductOptionPriceGroupId { get; set; } = null!;

    public int ProductOptionTypeId { get; set; }

    public string Description { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public int StoreId { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual ICollection<ProductOptionGroup> ProductOptionGroups { get; set; } = new List<ProductOptionGroup>();

    public virtual ICollection<ProductOptionPriceGroupDetail> ProductOptionPriceGroupDetails { get; set; } = new List<ProductOptionPriceGroupDetail>();

    public virtual ProductOptionType ProductOptionType { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;
}
