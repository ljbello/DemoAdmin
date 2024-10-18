using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblDiscount
{
    public int DisDiscountId { get; set; }

    public DateTime DisExpirationDate { get; set; }

    public string DisName { get; set; } = null!;

    public string? DisShortDescription { get; set; }

    public decimal CouDisPercentageDiscount { get; set; }

    public decimal CouDisLumpSumDiscount { get; set; }

    public int? CouDisQuantityLowerLimit { get; set; }

    public int? CouDisQuantityUpperLimit { get; set; }

    public decimal? CouDisTotalLowerLimit { get; set; }

    public decimal? CouDisTotalUpperLimit { get; set; }

    public int DisTypDiscountTypeId { get; set; }

    public int StoStoreId { get; set; }

    public int? DiscountByCategoryId { get; set; }

    public int? DiscountByProductTypeId { get; set; }

    public decimal? CreditAmount { get; set; }

    public string? CreditName { get; set; }

    public int? CreditCategoryId { get; set; }

    public int? CreditProductTypeId { get; set; }

    public int? DurationInDays { get; set; }

    public string? Reason { get; set; }

    public string? ReasonDetail { get; set; }

    public virtual TblDiscountType DisTypDiscountType { get; set; } = null!;

    public virtual Store StoStore { get; set; } = null!;

    public virtual ICollection<TblCouponDiscount> TblCouponDiscounts { get; set; } = new List<TblCouponDiscount>();

    public virtual ICollection<TblOrdersCoupon> TblOrdersCoupons { get; set; } = new List<TblOrdersCoupon>();
}
