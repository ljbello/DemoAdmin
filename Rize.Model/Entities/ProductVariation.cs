using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductVariation
{
    public int ProductVariationId { get; set; }

    public string Name { get; set; } = null!;

    public double Height { get; set; }

    public double Width { get; set; }

    public string FriendlyName { get; set; } = null!;

    public bool IsPanel { get; set; }

    public string? ImageName { get; set; }

    public string? Dimensions { get; set; }

    public int? SortRow { get; set; }

    public int? SortColumn { get; set; }

    public DateTime EntityCreated { get; set; }

    public string? ShortName { get; set; }

    public string? Description { get; set; }

    public int? ScaleDpi { get; set; }

    public bool? Preconverted { get; set; }

    public bool? ShowPrintSafe { get; set; }

    public bool? AllowAddressing { get; set; }

    public bool? AllowMailing { get; set; }

    public string? PlateType { get; set; }

    public bool AllowStamping { get; set; }

    public bool AllowAop { get; set; }

    public double? SafePrintDistance { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public int PlateResolution { get; set; }

    public bool? IsCircular { get; set; }

    public bool ShowBleedSwitch { get; set; }

    public bool BleedSwitchOn { get; set; }

    public byte PlateColorSpace { get; set; }

    public bool AllowTemplateOptions { get; set; }

    public bool ShowFrontTemplate { get; set; }

    public bool ShowBackTemplate { get; set; }

    public string? PrinterCode { get; set; }

    public int? ItemsPerSheet { get; set; }

    public string? Disclaimer { get; set; }

    public string? Format { get; set; }

    public virtual ICollection<AmazonProductMapping> AmazonProductMappings { get; set; } = new List<AmazonProductMapping>();

    public virtual ICollection<AutoProcessVariation> AutoProcessVariations { get; set; } = new List<AutoProcessVariation>();

    public virtual ICollection<CardSize> CardSizes { get; set; } = new List<CardSize>();

    public virtual ICollection<DiecutOption> DiecutOptions { get; set; } = new List<DiecutOption>();

    public virtual ICollection<MasterLayout> MasterLayouts { get; set; } = new List<MasterLayout>();

    public virtual ICollection<ProductConstructorCode> ProductConstructorCodes { get; set; } = new List<ProductConstructorCode>();

    public virtual ICollection<ProductProductVariationSupplierEnvelope> ProductProductVariationSupplierEnvelopes { get; set; } = new List<ProductProductVariationSupplierEnvelope>();

    public virtual ICollection<ProductProductVariation> ProductProductVariations { get; set; } = new List<ProductProductVariation>();

    public virtual ICollection<ProductSetupVariationAudit> ProductSetupVariationAudits { get; set; } = new List<ProductSetupVariationAudit>();

    public virtual ICollection<ProductTypeVariation> ProductTypeVariations { get; set; } = new List<ProductTypeVariation>();

    public virtual ICollection<ProductVariationMinMaxQuantity> ProductVariationMinMaxQuantities { get; set; } = new List<ProductVariationMinMaxQuantity>();

    public virtual ICollection<ProductVariationOptionGroup> ProductVariationOptionGroups { get; set; } = new List<ProductVariationOptionGroup>();

    public virtual ICollection<ProductVariationPaperStockFinishTemplate> ProductVariationPaperStockFinishTemplates { get; set; } = new List<ProductVariationPaperStockFinishTemplate>();

    public virtual ICollection<ProductVariationSectionFold> ProductVariationSectionFolds { get; set; } = new List<ProductVariationSectionFold>();

    public virtual ICollection<ProductVariationSectionPlate> ProductVariationSectionPlates { get; set; } = new List<ProductVariationSectionPlate>();

    public virtual ICollection<ProductVariationSection> ProductVariationSections { get; set; } = new List<ProductVariationSection>();

    public virtual ICollection<ShippingCostPredictionVariationWeight> ShippingCostPredictionVariationWeights { get; set; } = new List<ShippingCostPredictionVariationWeight>();

    public virtual ICollection<VariationPricingGroupDefault> VariationPricingGroupDefaults { get; set; } = new List<VariationPricingGroupDefault>();

    public virtual ICollection<VariationPricingGroupMapping> VariationPricingGroupMappings { get; set; } = new List<VariationPricingGroupMapping>();

    public virtual ICollection<VariationShippingGroup> VariationShippingGroups { get; set; } = new List<VariationShippingGroup>();

    public virtual ICollection<VariationSizeMapping> VariationSizeMappings { get; set; } = new List<VariationSizeMapping>();
}
