using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class Store
{
    public int StoreID { get; set; }

    public string StoDescription { get; set; } = null!;

    public string? StoCreditCardTransactionDescription { get; set; }

    public string StoCode { get; set; } = null!;

    public int StoGreetingCardDefaultQuantity { get; set; }

    public string StoNameForWebPageTitles { get; set; } = null!;

    public string? StoCardDetailPageMetaTagDescription { get; set; }

    public string? StoCardDetailPageMetaTagKeywords { get; set; }

    public string? StoSupportEmail { get; set; }

    public string? StoOrderEmail { get; set; }

    public string? StoShippingEmail { get; set; }

    public string? StoStockEmail { get; set; }

    public string? StoPhone1 { get; set; }

    public string? StoFax1 { get; set; }

    public string? StoDomain { get; set; }

    public string? StoArtworkEmail { get; set; }

    public string? StoOrderNumberPrefixLetter { get; set; }

    public bool? EnableMerchandisingScore { get; set; } = false;

    public bool Active { get; set; } = true;

    public string? YearlyOrderReminderEmail { get; set; } 

    public bool? AllowAop { get; set; } = false;

    public string? BillingEmail { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? BusinessUnit { get; set; }

    public string? ClientCode { get; set; }

    public string? Notes { get; set; }

    public string? StoreClosingMessage { get; set; }

    public int? FreightCalculator { get; set; }

    public string? LayoutTemplate { get; set; }

    public virtual ICollection<AdminStoreRoleTemplate> AdminStoreRoleTemplates { get; set; } = new List<AdminStoreRoleTemplate>();

    public virtual ICollection<AdminUserStore> AdminUserStores { get; set; } = new List<AdminUserStore>();

    public virtual ICollection<AmazonOrder> AmazonOrders { get; set; } = new List<AmazonOrder>();

    public virtual ICollection<AutoProcessVariation> AutoProcessVariations { get; set; } = new List<AutoProcessVariation>();

    public virtual ICollection<AutoTrigger> AutoTriggers { get; set; } = new List<AutoTrigger>();

    public virtual ICollection<DiscountGroup> DiscountGroups { get; set; } = new List<DiscountGroup>();

    public virtual ICollection<EmailLog> EmailLogs { get; set; } = new List<EmailLog>();

    public virtual ICollection<EmailTemplate> EmailTemplates { get; set; } = new List<EmailTemplate>();

    public virtual ICollection<EmailTypeStore> EmailTypeStores { get; set; } = new List<EmailTypeStore>();

    public virtual ICollection<FaqItem> FaqItems { get; set; } = new List<FaqItem>();

    public virtual ICollection<MarketingFormEntry> MarketingFormEntries { get; set; } = new List<MarketingFormEntry>();

    public virtual ICollection<MerchandisingSortingParameter> MerchandisingSortingParameters { get; set; } = new List<MerchandisingSortingParameter>();

    public virtual ICollection<PaperStockFinishPricingVersion> PaperStockFinishPricingVersions { get; set; } = new List<PaperStockFinishPricingVersion>();

    public virtual ICollection<ProductConstructorCode> ProductConstructorCodes { get; set; } = new List<ProductConstructorCode>();

    public virtual ICollection<ProductOptionPriceGroup> ProductOptionPriceGroups { get; set; } = new List<ProductOptionPriceGroup>();

    public virtual ICollection<ProductProductVariationSupplierEnvelope> ProductProductVariationSupplierEnvelopes { get; set; } = new List<ProductProductVariationSupplierEnvelope>();

    public virtual ICollection<ProductTypeQuantity> ProductTypeQuantities { get; set; } = new List<ProductTypeQuantity>();

    public virtual ICollection<ProductTypeWeight> ProductTypeWeights { get; set; } = new List<ProductTypeWeight>();

    public virtual ICollection<ProductVariationMinMaxQuantity> ProductVariationMinMaxQuantities { get; set; } = new List<ProductVariationMinMaxQuantity>();

    public virtual ICollection<ProductVariationOptionGroup> ProductVariationOptionGroups { get; set; } = new List<ProductVariationOptionGroup>();

    public virtual ICollection<SampleKitRequest> SampleKitRequests { get; set; } = new List<SampleKitRequest>();

    public virtual ICollection<ShareAsaleDatum> ShareAsaleData { get; set; } = new List<ShareAsaleDatum>();

    public virtual ICollection<ShippingGroup> ShippingGroups { get; set; } = new List<ShippingGroup>();

    public virtual ICollection<StoreAppsetting> StoreAppsettings { get; set; } = new List<StoreAppsetting>();

    public virtual ICollection<StoreConfig> StoreConfigs { get; set; } = new List<StoreConfig>();

    public virtual ICollection<StoreFont> StoreFonts { get; set; } = new List<StoreFont>();

    public virtual ICollection<StorePayment> StorePayments { get; set; } = new List<StorePayment>();

    public virtual ICollection<StoreProductType> StoreProductTypes { get; set; } = new List<StoreProductType>();

    public virtual ICollection<StoreShippingMethod> StoreShippingMethods { get; set; } = new List<StoreShippingMethod>();

    public virtual ICollection<TblCatalog> TblCatalogs { get; set; } = new List<TblCatalog>();

    public virtual ICollection<TblCouponDiscount> TblCouponDiscounts { get; set; } = new List<TblCouponDiscount>();

    public virtual ICollection<TblCoupon> TblCoupons { get; set; } = new List<TblCoupon>();

    public virtual ICollection<TblCustomer> TblCustomers { get; set; } = new List<TblCustomer>();

    public virtual ICollection<TblDiscount> TblDiscounts { get; set; } = new List<TblDiscount>();

    public virtual ICollection<TblPricingGroup> TblPricingGroups { get; set; } = new List<TblPricingGroup>();

    public virtual ICollection<TblRedirect> TblRedirects { get; set; } = new List<TblRedirect>();

    public virtual ICollection<TblSearchTermRedirect> TblSearchTermRedirects { get; set; } = new List<TblSearchTermRedirect>();

    public virtual ICollection<TblSearchTerm> TblSearchTerms { get; set; } = new List<TblSearchTerm>();

    public virtual ICollection<TblStoreDepartmentCategory> TblStoreDepartmentCategories { get; set; } = new List<TblStoreDepartmentCategory>();

    public virtual ICollection<TblStoreDepartment> TblStoreDepartments { get; set; } = new List<TblStoreDepartment>();

    public virtual ICollection<TblStoreProduct> TblStoreProducts { get; set; } = new List<TblStoreProduct>();

    public virtual ICollection<TblStoreRetailDiscount> TblStoreRetailDiscounts { get; set; } = new List<TblStoreRetailDiscount>();

    public virtual ICollection<TblStoreSupplierRetailDiscount> TblStoreSupplierRetailDiscounts { get; set; } = new List<TblStoreSupplierRetailDiscount>();

    public virtual ICollection<TblStoreSupplier> TblStoreSuppliers { get; set; } = new List<TblStoreSupplier>();

    public virtual ICollection<TblStoreSuppliersIcsmxmlToid> TblStoreSuppliersIcsmxmlToids { get; set; } = new List<TblStoreSuppliersIcsmxmlToid>();

    public virtual ICollection<TblSupplierEnvelopesPricingVersion> TblSupplierEnvelopesPricingVersions { get; set; } = new List<TblSupplierEnvelopesPricingVersion>();

    public virtual ICollection<TblSupplierPricing> TblSupplierPricings { get; set; } = new List<TblSupplierPricing>();

    public virtual ICollection<VariationPricingGroupDefault> VariationPricingGroupDefaults { get; set; } = new List<VariationPricingGroupDefault>();

    public virtual ICollection<VariationPricingGroup> VariationPricingGroups { get; set; } = new List<VariationPricingGroup>();
}
