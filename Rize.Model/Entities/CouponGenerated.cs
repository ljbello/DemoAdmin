using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CouponGenerated
{
    public int Id { get; set; }

    public int CouponId { get; set; }

    public string PromoCode { get; set; } = null!;

    public bool IsRedeemed { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? RedeemedOn { get; set; }

    public virtual TblCoupon Coupon { get; set; } = null!;
}
