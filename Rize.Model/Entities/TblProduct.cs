using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblProduct
{
    public int ProProductId { get; set; }

    public string ProProductNumber { get; set; } = null!;

    public int SupSupplierId { get; set; }

    public string? ProSupplierProductNumber { get; set; }

    public string? ProPunchoutProductNumber { get; set; }

    public int? ManManufacturerId { get; set; }

    public string? ProManufacturerProductNumber { get; set; }

    public string? ProInternalNotes { get; set; }

    public decimal? ProPrice { get; set; }

    public string? ProAdditionalKeywords { get; set; }

    public int ProTimProductionTimeId { get; set; }

    public DateTime ProDateAdded { get; set; }

    public bool ProSoldInPacks { get; set; }

    public int? ProCardsPerPack { get; set; }

    public int? ProSampleSupplierId { get; set; }

    public DateTime? ProSampleOnOrderDate { get; set; }

    public string? ProManufacturerItemNumber { get; set; }

    public int ProPreviewVersion { get; set; }

    public string? ProLogoSet { get; set; }

    public int? ThumbnailImageCount { get; set; }

    public string? VerseInkColor { get; set; }

    public string? CustomColors { get; set; }

    public decimal? WeightPer25 { get; set; }

    public bool IsExclusive { get; set; }

    public bool AllowCustomSample { get; set; }

    public bool IsEnvelopeOptional { get; set; }

    public int? ImageCount { get; set; }

    public int? EnvironmentImageCount { get; set; }

    public int? ProductDesignerId { get; set; }

    public int? ArtworkSourceId { get; set; }

    public string? CategoryDisplayClass { get; set; }

    public bool? AutoExclusive { get; set; }

    public int? ProductUseId { get; set; }

    public int ProductTypeId { get; set; }

    public int ProductionTypeId { get; set; }

    public bool? EditorAnimationsOff { get; set; }

    public bool DeckledEdge { get; set; }

    public bool Embossed { get; set; }

    public bool Foil { get; set; }

    public bool LaserCut { get; set; }

    public bool PhotoSlot { get; set; }

    public bool Scored { get; set; }

    public int? OccasionIdDefault { get; set; }

    public int? ThemeIdDefault { get; set; }

    public int? StyleIdDefault { get; set; }

    public int? CollectionIdDefault { get; set; }

    public bool? AllowFullColor { get; set; }

    public bool IsDieCut { get; set; }

    public bool AllowAddressing { get; set; }

    public bool AllowMailing { get; set; }

    public bool AllowStamping { get; set; }

    public bool ShowOnMobileDesktopAlert { get; set; }

    public DateTime UpdatedOn { get; set; }

    public bool IsInventoryVisible { get; set; }

    public string? VendorArtworkId { get; set; }

    public virtual ICollection<AmazonProductMapping> AmazonProductMappings { get; set; } = new List<AmazonProductMapping>();

    public virtual AssortmentPack? AssortmentPack { get; set; }

    public virtual ICollection<BvfeedEntry> BvfeedEntries { get; set; } = new List<BvfeedEntry>();

    public virtual ICollection<CustomerFavorite> CustomerFavorites { get; set; } = new List<CustomerFavorite>();

    public virtual ICollection<DigitalProductOption> DigitalProductOptions { get; set; } = new List<DigitalProductOption>();

    public virtual FoilProduct? FoilProduct { get; set; }

    public virtual TblManufacturer? ManManufacturer { get; set; }

    public virtual TblSupplier? ProSampleSupplier { get; set; }

    public virtual TblProductionTime ProTimProductionTime { get; set; } = null!;

    public virtual ICollection<ProductColor> ProductColors { get; set; } = new List<ProductColor>();

    public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();

    public virtual ICollection<ProductOccasion> ProductOccasions { get; set; } = new List<ProductOccasion>();

    public virtual ICollection<ProductOptionGroup> ProductOptionGroups { get; set; } = new List<ProductOptionGroup>();

    public virtual ICollection<ProductOptionImage> ProductOptionImages { get; set; } = new List<ProductOptionImage>();

    public virtual ICollection<ProductPaperStockFinish> ProductPaperStockFinishes { get; set; } = new List<ProductPaperStockFinish>();

    public virtual ICollection<ProductProductVariationSupplierEnvelope> ProductProductVariationSupplierEnvelopes { get; set; } = new List<ProductProductVariationSupplierEnvelope>();

    public virtual ICollection<ProductProductVariation> ProductProductVariations { get; set; } = new List<ProductProductVariation>();

    public virtual ICollection<ProductSetupAudit> ProductSetupAudits { get; set; } = new List<ProductSetupAudit>();

    public virtual ICollection<ProductStyle> ProductStyles { get; set; } = new List<ProductStyle>();

    public virtual ICollection<ProductTheme> ProductThemes { get; set; } = new List<ProductTheme>();

    public virtual ProductType ProductType { get; set; } = null!;

    public virtual ICollection<ProductVariationSectionPlate> ProductVariationSectionPlates { get; set; } = new List<ProductVariationSectionPlate>();

    public virtual ICollection<RelatedProduct> RelatedProducts { get; set; } = new List<RelatedProduct>();

    public virtual ICollection<SavedProject> SavedProjects { get; set; } = new List<SavedProject>();

    public virtual TblSupplier SupSupplier { get; set; } = null!;

    public virtual ICollection<SupplierProductMapping> SupplierProductMappings { get; set; } = new List<SupplierProductMapping>();

    public virtual TblChristmasCard? TblChristmasCard { get; set; }

    public virtual ICollection<TblDepartmentProduct> TblDepartmentProducts { get; set; } = new List<TblDepartmentProduct>();

    public virtual ICollection<TblOrderLine> TblOrderLineOrdLinReferenceProducts { get; set; } = new List<TblOrderLine>();

    public virtual ICollection<TblOrderLine> TblOrderLineProProducts { get; set; } = new List<TblOrderLine>();

    public virtual ICollection<TblProductSimilarProductCode> TblProductSimilarProductCodes { get; set; } = new List<TblProductSimilarProductCode>();

    public virtual ICollection<TblStoreProduct> TblStoreProducts { get; set; } = new List<TblStoreProduct>();

    public virtual ICollection<TblInkColor> InkColInkColors { get; set; } = new List<TblInkColor>();
}
