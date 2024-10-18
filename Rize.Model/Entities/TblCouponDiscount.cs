using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCouponDiscount
{
    public int CouDisCouponDiscountId { get; set; }

    public int CouCouponId { get; set; }

    public int DisDiscountId { get; set; }

    public int StoStoreId { get; set; }

    public virtual TblCoupon CouCoupon { get; set; } = null!;

    public virtual TblDiscount DisDiscount { get; set; } = null!;

    public virtual Store StoStore { get; set; } = null!;
}
