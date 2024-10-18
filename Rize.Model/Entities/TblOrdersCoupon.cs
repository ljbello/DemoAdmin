using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrdersCoupon
{
    public int OrdCouOrderCouponId { get; set; }

    public int OrdOrderId { get; set; }

    public int CouCouponId { get; set; }

    public int? DisDiscountId { get; set; }

    public decimal? OrdCouAdditionalDiscountTotal { get; set; }

    public string? OrdCouVariableDiscountCode { get; set; }

    public string? CouponTrackingCode { get; set; }

    public virtual TblCoupon CouCoupon { get; set; } = null!;

    public virtual TblDiscount? DisDiscount { get; set; }

    public virtual Order OrdOrder { get; set; } = null!;
}
