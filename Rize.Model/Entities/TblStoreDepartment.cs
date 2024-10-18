using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblStoreDepartment
{
    public int StoStoreId { get; set; }

    public int DepDepartmentId { get; set; }

    public bool StoDepActive { get; set; }

    public string StoDepName { get; set; } = null!;

    public string? StoDepPageMarketingDescription { get; set; }

    public string? StoDepPageMarketingDescription2 { get; set; }

    public string? StoDepPrimaryDirectoryPath { get; set; }

    public string? StoDepPageTitle { get; set; }

    public string? StoDepPageMetaTagDescription { get; set; }

    public string? StoDepPageMetaTagKeywords { get; set; }

    public string? StoDepPageLogoText { get; set; }

    public string? StoDepPageHeaderText { get; set; }

    public string? StoDepPageHeaderText2 { get; set; }

    public string? StoDepPagePageName { get; set; }

    public string? StoDepPageTopTag { get; set; }

    public string? StoDepPageBottomTag { get; set; }

    public string? StoDepPageHolidayBarStyle { get; set; }

    public bool StoDepUseDepartmentRank { get; set; }

    public int StoDepNavDestinationTypeId { get; set; }

    public virtual TblDepartment DepDepartment { get; set; } = null!;

    public virtual NavDestinationType StoDepNavDestinationType { get; set; } = null!;

    public virtual Store StoStore { get; set; } = null!;
}
