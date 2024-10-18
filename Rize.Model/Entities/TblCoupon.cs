using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCoupon
{
    public int CouCouponId { get; set; }

    public string CouCouponCode { get; set; } = null!;

    public string CouCouponBriefDescription { get; set; } = null!;

    public string CouDescription { get; set; } = null!;

    public DateTime CouMadePublicStartDate { get; set; }

    public DateTime CouMadePublicEndDate { get; set; }

    public string CouClaimCode { get; set; } = null!;

    public int CouNumTimesValidPerCustomerId { get; set; }

    public int? CouNumTimesValid { get; set; }

    public decimal? CouOriginalValue { get; set; }

    public decimal? CouBalance { get; set; }

    public int? CatCatalogId { get; set; }

    public DateTime? MailDate { get; set; }

    public int? CirculationCount { get; set; }

    public decimal? CostPerPiece { get; set; }

    public string? CampaignNotes { get; set; }

    public bool IsStackable { get; set; }

    public int StoreId { get; set; }

    public string? MaxReachedErrorMsg { get; set; }

    public int MaxUsageType { get; set; }

    public virtual ICollection<CouponGenerated> CouponGenerateds { get; set; } = new List<CouponGenerated>();

    public virtual Store Store { get; set; } = null!;

    public virtual ICollection<TblCouponDiscount> TblCouponDiscounts { get; set; } = new List<TblCouponDiscount>();

    public virtual ICollection<TblOrdersCoupon> TblOrdersCoupons { get; set; } = new List<TblOrdersCoupon>();
}
