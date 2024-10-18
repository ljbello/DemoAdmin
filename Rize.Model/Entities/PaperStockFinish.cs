using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class PaperStockFinish
{
    public int PaperStockFinishId { get; set; }

    public int PaperStockId { get; set; }

    public int PaperFinishId { get; set; }

    public string? InternalName { get; set; }

    public string? DisplayName { get; set; }

    public string? ImageName { get; set; }

    public string? Description { get; set; }

    public int? SortId { get; set; }

    public string? SupplierPaperFinishCode { get; set; }

    public string? SupplierPaperWeightCode { get; set; }

    public string? SupplierPaperColorCode { get; set; }

    public string? LogoSetType { get; set; }

    public string? PaperStockImage { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public string? Disclaimer { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<AmazonProductMapping> AmazonProductMappings { get; set; } = new List<AmazonProductMapping>();

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual ICollection<OrderLinePersonalization> OrderLinePersonalizations { get; set; } = new List<OrderLinePersonalization>();

    public virtual ICollection<ProductPaperStockFinish> ProductPaperStockFinishes { get; set; } = new List<ProductPaperStockFinish>();

    public virtual ICollection<ProductVariationPaperStockFinishTemplate> ProductVariationPaperStockFinishTemplates { get; set; } = new List<ProductVariationPaperStockFinishTemplate>();

    public virtual ICollection<ShippingCostPredictionVariationWeight> ShippingCostPredictionVariationWeights { get; set; } = new List<ShippingCostPredictionVariationWeight>();
}
