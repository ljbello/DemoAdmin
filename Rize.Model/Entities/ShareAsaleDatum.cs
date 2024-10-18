using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ShareAsaleDatum
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int TransId { get; set; }

    public int UserId { get; set; }

    public DateTime TransDate { get; set; }

    public decimal TransAmount { get; set; }

    public decimal Commission { get; set; }

    public decimal? Ssamount { get; set; }

    public string? Comment { get; set; }

    public bool? Voided { get; set; }

    public bool? Locked { get; set; }

    public bool? Pending { get; set; }

    public string? LastIp { get; set; }

    public string? LastReferer { get; set; }

    public string? BannerNumber { get; set; }

    public string? BannerPage { get; set; }

    public DateTime? DateOfTrans { get; set; }

    public DateTime? DateOfClick { get; set; }

    public string? TimeOfClick { get; set; }

    public DateTime? DateOfReversal { get; set; }

    public int? ReturnDays { get; set; }

    public string? ToolId { get; set; }

    public int StoreId { get; set; }

    public DateTime? LockDate { get; set; }

    public string? TransactionType { get; set; }

    public string? CommissionType { get; set; }

    public string? Skulist { get; set; }

    public decimal? PriceList { get; set; }

    public int? QuantityList { get; set; }

    public string? OrderNumber { get; set; }

    public string? ParentTrans { get; set; }

    public string? BannerName { get; set; }

    public string? BannerType { get; set; }

    public string? CouponCode { get; set; }

    public string? ReferenceTrans { get; set; }

    public bool? NewCustomerFlag { get; set; }

    public string? UserAgent { get; set; }

    public string? OriginalCurrency { get; set; }

    public decimal? OriginalCurrentAmount { get; set; }

    public bool? IsMobile { get; set; }

    public bool? UsedAcoupon { get; set; }

    public string? MerchantDefinedType { get; set; }

    public virtual Store Store { get; set; } = null!;
}
