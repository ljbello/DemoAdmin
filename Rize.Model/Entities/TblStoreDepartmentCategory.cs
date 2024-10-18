using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblStoreDepartmentCategory
{
    public int StoStoreId { get; set; }

    public int DepDepartmentId { get; set; }

    public string StoDepCatTitle { get; set; } = null!;

    public string StoDepCatPrimaryKeyword { get; set; } = null!;

    public string StoDepCatLinkTitle { get; set; } = null!;

    public bool StoDepCatAlwaysShow { get; set; }

    public string? StoDepCatTagline { get; set; }

    public string? StoDepCatBodyBoxTitle { get; set; }

    public string StoDepCatCardTotalLine { get; set; } = null!;

    public string StoDepCatPaginationLinkTitle { get; set; } = null!;

    public string StoDepCatBanner { get; set; } = null!;

    public string StoDepCatBannerPages { get; set; } = null!;

    public string? HeaderMetaTags { get; set; }

    public virtual TblDepartment DepDepartment { get; set; } = null!;

    public virtual Store StoStore { get; set; } = null!;
}
