using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblSupplierPricing
{
    public int SupPriPricingGroupId { get; set; }

    public string? SupPriPricingGroupDescription { get; set; }

    public string SupPriPriceId { get; set; } = null!;

    public int SupSupplierId { get; set; }

    public int? StoreId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public virtual TblUser? CreatedByNavigation { get; set; }

    public virtual Store? Store { get; set; }

    public virtual TblSupplier SupSupplier { get; set; } = null!;

    public virtual ICollection<VariationPricingGroupMapping> VariationPricingGroupMappings { get; set; } = new List<VariationPricingGroupMapping>();
}
