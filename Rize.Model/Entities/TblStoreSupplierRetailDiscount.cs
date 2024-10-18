using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblStoreSupplierRetailDiscount
{
    public int StoSupRetDisStoreSupplierRetailDiscountId { get; set; }

    public int StoStoreId { get; set; }

    public int SupSupplierId { get; set; }

    public int StoSupRetDisLowerLimit { get; set; }

    public int StoSupRetDisUpperLimit { get; set; }

    public decimal StoSupRetDisDiscount { get; set; }

    public int PriGroPricingGroupId { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual TblUser ModifiedByNavigation { get; set; } = null!;

    public virtual Store StoStore { get; set; } = null!;

    public virtual TblSupplier SupSupplier { get; set; } = null!;

    public virtual TblPricingGroup TblPricingGroup { get; set; } = null!;
}
