using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblStoreProduct
{
    public int StoStoreId { get; set; }

    public int ProProductId { get; set; }

    public int StoProNumberOfSales { get; set; }

    public int StoProDisplayOffset { get; set; }

    public string? StoProName { get; set; }

    public string? StoProPageTitle { get; set; }

    public int? DepDepartmentIdDefault { get; set; }

    public string? StoProRedirectUrl { get; set; }

    public DateTime? DisplayOffsetUpdatedDate { get; set; }

    public double? MerchandisingScore { get; set; }

    public DateTime? MerchandisingDate { get; set; }

    public string? StoProDescription { get; set; }

    public int? PriGroPricingGroupId { get; set; }

    public decimal? StarCount { get; set; }

    public int? ReviewCount { get; set; }

    public DateTime? ActiveDate { get; set; }

    public int? ProStaProductStatusId { get; set; }

    public string? MetaDescription { get; set; }

    public virtual TblProduct ProProduct { get; set; } = null!;

    public virtual TblProductStatus? ProStaProductStatus { get; set; }

    public virtual ICollection<ProductSetupVariationAudit> ProductSetupVariationAudits { get; set; } = new List<ProductSetupVariationAudit>();

    public virtual Store StoStore { get; set; } = null!;
}
