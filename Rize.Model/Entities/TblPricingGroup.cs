using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblPricingGroup
{
    public int PriGroPricingGroupId { get; set; }

    public string? PriGroPricingGroup { get; set; }

    public string? PriGroPricingGroupAbrev { get; set; }

    public int StoreId { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public virtual TblUser? CreatedByNavigation { get; set; }

    public virtual Store Store { get; set; } = null!;

    public virtual ICollection<TblStoreRetailDiscount> TblStoreRetailDiscounts { get; set; } = new List<TblStoreRetailDiscount>();

    public virtual ICollection<TblStoreSupplierRetailDiscount> TblStoreSupplierRetailDiscounts { get; set; } = new List<TblStoreSupplierRetailDiscount>();
}
