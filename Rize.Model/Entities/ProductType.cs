using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductType
{
    public int ProductTypeId { get; set; }

    public string ProductType1 { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public bool ShowStartAtPrice { get; set; }

    public string? ProductNumberPrefix { get; set; }

    public bool? AllowAop { get; set; }

    public int DefaultProductionTimeId { get; set; }

    public int VertexProductCodeId { get; set; }

    public virtual TblUser? CreatedByNavigation { get; set; }

    public virtual TblProductionTime DefaultProductionTime { get; set; } = null!;

    public virtual ICollection<DiscountGroupProductType> DiscountGroupProductTypes { get; set; } = new List<DiscountGroupProductType>();

    public virtual ICollection<ProductConstructorCode> ProductConstructorCodes { get; set; } = new List<ProductConstructorCode>();

    public virtual ICollection<ProductTypeProduction> ProductTypeProductions { get; set; } = new List<ProductTypeProduction>();

    public virtual ICollection<ProductTypeQuantity> ProductTypeQuantities { get; set; } = new List<ProductTypeQuantity>();

    public virtual ICollection<ProductTypeVariation> ProductTypeVariations { get; set; } = new List<ProductTypeVariation>();

    public virtual ICollection<ProductTypeWeight> ProductTypeWeights { get; set; } = new List<ProductTypeWeight>();

    public virtual ICollection<StoreProductType> StoreProductTypes { get; set; } = new List<StoreProductType>();

    public virtual ICollection<TblInkColor> TblInkColors { get; set; } = new List<TblInkColor>();

    public virtual ICollection<TblProduct> TblProducts { get; set; } = new List<TblProduct>();

    public virtual ICollection<TblSize> TblSizes { get; set; } = new List<TblSize>();

    public virtual ICollection<TblTypestyle> TblTypestyles { get; set; } = new List<TblTypestyle>();

    public virtual ICollection<TblVerse> TblVerses { get; set; } = new List<TblVerse>();

    public virtual ICollection<VariationPricingGroupDefault> VariationPricingGroupDefaults { get; set; } = new List<VariationPricingGroupDefault>();

    public virtual ICollection<VariationPricingGroupMapping> VariationPricingGroupMappings { get; set; } = new List<VariationPricingGroupMapping>();

    public virtual ICollection<VariationPricingGroup> VariationPricingGroups { get; set; } = new List<VariationPricingGroup>();
}
