using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductSetupVariationAudit
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public int ProductId { get; set; }

    public string VersionXml { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public int VariationId { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual TblStoreProduct TblStoreProduct { get; set; } = null!;

    public virtual ProductVariation Variation { get; set; } = null!;
}
