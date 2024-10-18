using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Rize.Model.Entities;

namespace Rize.Model.ApplicationDBcontext;

public partial class CDEntities : DbContext
{
    public CDEntities()
    {
        this.ChangeTracker.LazyLoadingEnabled = false;
    }

    public CDEntities(DbContextOptions<CDEntities> options)
        : base(options)
    {
        this.ChangeTracker.LazyLoadingEnabled = false;
    }

    public virtual DbSet<AdminPage> AdminPages { get; set; }

    public virtual DbSet<AdminPagePanel> AdminPagePanels { get; set; }

    public virtual DbSet<AdminPanel> AdminPanels { get; set; }

    public virtual DbSet<AdminPanelLock> AdminPanelLocks { get; set; }

    public virtual DbSet<AdminPanelRoleTemplate> AdminPanelRoleTemplates { get; set; }

    public virtual DbSet<AdminPanelUserPermission> AdminPanelUserPermissions { get; set; }

    public virtual DbSet<AdminRole> AdminRoles { get; set; }

    public virtual DbSet<AdminShortcut> AdminShortcuts { get; set; }

    public virtual DbSet<AdminStoreRoleTemplate> AdminStoreRoleTemplates { get; set; }

    public virtual DbSet<AdminTreeNode> AdminTreeNodes { get; set; }

    public virtual DbSet<AdminTreeNodeRole> AdminTreeNodeRoles { get; set; }

    public virtual DbSet<AdminTreeNodeUserPermission> AdminTreeNodeUserPermissions { get; set; }

    public virtual DbSet<AdminUserPost> AdminUserPosts { get; set; }

    public virtual DbSet<AdminUserRole> AdminUserRoles { get; set; }

    public virtual DbSet<AdminUserStore> AdminUserStores { get; set; }

    public virtual DbSet<AlertMain> AlertMains { get; set; }

    public virtual DbSet<AlertNoGetLowestPrice> AlertNoGetLowestPrices { get; set; }

    public virtual DbSet<AlertNotifier> AlertNotifiers { get; set; }

    public virtual DbSet<AlertRecipient> AlertRecipients { get; set; }

    public virtual DbSet<AmazonOrder> AmazonOrders { get; set; }

    public virtual DbSet<AmazonOrderItem> AmazonOrderItems { get; set; }

    public virtual DbSet<AmazonProductMapping> AmazonProductMappings { get; set; }

    public virtual DbSet<AnnualBudget> AnnualBudgets { get; set; }

    public virtual DbSet<AopexclusionProduct> AopexclusionProducts { get; set; }

    public virtual DbSet<AopworkTable> AopworkTables { get; set; }

    public virtual DbSet<AopworkTableDebug> AopworkTableDebugs { get; set; }

    public virtual DbSet<AopworkTableRemoval> AopworkTableRemovals { get; set; }

    public virtual DbSet<AopworkTableRemovalsTrack> AopworkTableRemovalsTracks { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<AreaDefault> AreaDefaults { get; set; }

    public virtual DbSet<AreaName> AreaNames { get; set; }

    public virtual DbSet<AreaToken> AreaTokens { get; set; }

    public virtual DbSet<AreaType> AreaTypes { get; set; }

    public virtual DbSet<ArtworkStatus> ArtworkStatuses { get; set; }

    public virtual DbSet<AssortmentPack> AssortmentPacks { get; set; }

    public virtual DbSet<AssortmentPackImage> AssortmentPackImages { get; set; }

    public virtual DbSet<AutoCompleteText> AutoCompleteTexts { get; set; }

    public virtual DbSet<AutoOrderProcessHistory> AutoOrderProcessHistories { get; set; }

    public virtual DbSet<AutoProcessVariation> AutoProcessVariations { get; set; }

    public virtual DbSet<AutoProductImportLog> AutoProductImportLogs { get; set; }

    public virtual DbSet<AutoTrigger> AutoTriggers { get; set; }

    public virtual DbSet<AutoTriggerAction> AutoTriggerActions { get; set; }

    public virtual DbSet<AutoTriggerActionLookUp> AutoTriggerActionLookUps { get; set; }

    public virtual DbSet<AutoTriggerHistory> AutoTriggerHistories { get; set; }

    public virtual DbSet<AutoTriggerRule> AutoTriggerRules { get; set; }

    public virtual DbSet<AutoTriggerWhenField> AutoTriggerWhenFields { get; set; }

    public virtual DbSet<BaseEnvelopePricing> BaseEnvelopePricings { get; set; }

    public virtual DbSet<BasePaperStockFinishPricing> BasePaperStockFinishPricings { get; set; }

    public virtual DbSet<BaseProductPricingGroup> BaseProductPricingGroups { get; set; }

    public virtual DbSet<BaseProductPricingInfo> BaseProductPricingInfos { get; set; }

    public virtual DbSet<BaseVariationOptionSidesPricing> BaseVariationOptionSidesPricings { get; set; }

    public virtual DbSet<BirthdayLoyalty> BirthdayLoyalties { get; set; }

    public virtual DbSet<BvfeedEntry> BvfeedEntries { get; set; }

    public virtual DbSet<CardSize> CardSizes { get; set; }

    public virtual DbSet<CardSizeSizeMapping> CardSizeSizeMappings { get; set; }

    public virtual DbSet<CatalogRequestEmailReminder> CatalogRequestEmailReminders { get; set; }

    public virtual DbSet<CatalogUnsubcribe> CatalogUnsubcribes { get; set; }

    public virtual DbSet<CategoryTotal> CategoryTotals { get; set; }

    public virtual DbSet<CdcardImport> CdcardImports { get; set; }

    public virtual DbSet<CharityOrder> CharityOrders { get; set; }

    public virtual DbSet<CmscontentArea> CmscontentAreas { get; set; }

    public virtual DbSet<CmscontentAreaAudit> CmscontentAreaAudits { get; set; }

    public virtual DbSet<Cmspage> Cmspages { get; set; }

    public virtual DbSet<CmspageAudit> CmspageAudits { get; set; }

    public virtual DbSet<CmspageTemplate> CmspageTemplates { get; set; }

    public virtual DbSet<Collection> Collections { get; set; }

    public virtual DbSet<ColorGroup> ColorGroups { get; set; }

    public virtual DbSet<ColorGroupColor> ColorGroupColors { get; set; }

    public virtual DbSet<CommandLog> CommandLogs { get; set; }

    public virtual DbSet<CorporateBilling> CorporateBillings { get; set; }

    public virtual DbSet<CouponGenerated> CouponGenerateds { get; set; }

    public virtual DbSet<CouponTracker> CouponTrackers { get; set; }

    public virtual DbSet<CouponTrackerOrder> CouponTrackerOrders { get; set; }

    public virtual DbSet<CreditCardBinRange> CreditCardBinRanges { get; set; }

    public virtual DbSet<CreditCardErrorMessage> CreditCardErrorMessages { get; set; }

    public virtual DbSet<CreditReason> CreditReasons { get; set; }

    public virtual DbSet<CreditReasonDetail> CreditReasonDetails { get; set; }

    public virtual DbSet<CustomerAccount> CustomerAccounts { get; set; }

    public virtual DbSet<CustomerAccountCredit> CustomerAccountCredits { get; set; }

    public virtual DbSet<CustomerArtworkCodeMapping> CustomerArtworkCodeMappings { get; set; }

    public virtual DbSet<CustomerFavorite> CustomerFavorites { get; set; }

    public virtual DbSet<CustomerGallery> CustomerGalleries { get; set; }

    public virtual DbSet<CustomerHistoryPassword> CustomerHistoryPasswords { get; set; }

    public virtual DbSet<CustomerLogin> CustomerLogins { get; set; }

    public virtual DbSet<CustomerMetricsOrderProcessing> CustomerMetricsOrderProcessings { get; set; }

    public virtual DbSet<CustomerPaymentMethod> CustomerPaymentMethods { get; set; }

    public virtual DbSet<CustomerProofRequest> CustomerProofRequests { get; set; }

    public virtual DbSet<CustomerReviewPhoto> CustomerReviewPhotos { get; set; }

    public virtual DbSet<CustomerUsedUpload> CustomerUsedUploads { get; set; }

    public virtual DbSet<DataFeedGoogle> DataFeedGoogles { get; set; }

    public virtual DbSet<DataFeedGoogleLog> DataFeedGoogleLogs { get; set; }

    public virtual DbSet<DataFeedUnBx> DataFeedUnBxes { get; set; }

    public virtual DbSet<DayStarExclusionDetail> DayStarExclusionDetails { get; set; }

    public virtual DbSet<DayStarExclusionHeader> DayStarExclusionHeaders { get; set; }

    public virtual DbSet<DeliveryEstimationAuditDetail> DeliveryEstimationAuditDetails { get; set; }

    public virtual DbSet<DeliveryEstimationAuditHeader> DeliveryEstimationAuditHeaders { get; set; }

    public virtual DbSet<DeliveryEstimationCategory> DeliveryEstimationCategories { get; set; }

    public virtual DbSet<DeliveryEstimationCategoryElement> DeliveryEstimationCategoryElements { get; set; }

    public virtual DbSet<DeliveryEstimationCategoryElementBySupplier> DeliveryEstimationCategoryElementBySuppliers { get; set; }

    public virtual DbSet<DeliveryEstimationSupplierClosure> DeliveryEstimationSupplierClosures { get; set; }

    public virtual DbSet<DeliveryEstimationSupplierOrderCutOff> DeliveryEstimationSupplierOrderCutOffs { get; set; }

    public virtual DbSet<DepartmentOccasionMapping> DepartmentOccasionMappings { get; set; }

    public virtual DbSet<DepartmentProductTypeMapping> DepartmentProductTypeMappings { get; set; }

    public virtual DbSet<DepartmentStyleMapping> DepartmentStyleMappings { get; set; }

    public virtual DbSet<DiecutOption> DiecutOptions { get; set; }

    public virtual DbSet<DigitalPressProductsWithSamplePlate> DigitalPressProductsWithSamplePlates { get; set; }

    public virtual DbSet<DigitalProductOption> DigitalProductOptions { get; set; }

    public virtual DbSet<DiscountGroup> DiscountGroups { get; set; }

    public virtual DbSet<DiscountGroupProductType> DiscountGroupProductTypes { get; set; }

    public virtual DbSet<DiscountGroupQuantity> DiscountGroupQuantities { get; set; }

    public virtual DbSet<DiscountGroupSchedule> DiscountGroupSchedules { get; set; }

    public virtual DbSet<DiscountShipping> DiscountShippings { get; set; }

    public virtual DbSet<DomoIpexclusion> DomoIpexclusions { get; set; }

    public virtual DbSet<Email> Emails { get; set; }

    public virtual DbSet<EmailErrorResolution> EmailErrorResolutions { get; set; }

    public virtual DbSet<EmailLog> EmailLogs { get; set; }

    public virtual DbSet<EmailLogHistory> EmailLogHistories { get; set; }

    public virtual DbSet<EmailSentQueue> EmailSentQueues { get; set; }

    public virtual DbSet<EmailSubscription> EmailSubscriptions { get; set; }

    public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }

    public virtual DbSet<EmailType> EmailTypes { get; set; }

    public virtual DbSet<EmailTypeStore> EmailTypeStores { get; set; }

    public virtual DbSet<EmployeeInternalEmail> EmployeeInternalEmails { get; set; }

    public virtual DbSet<EnumOrderStatus> EnumOrderStatuses { get; set; }

    public virtual DbSet<EnumSupplier> EnumSuppliers { get; set; }

    public virtual DbSet<EnumWorkFlowStep> EnumWorkFlowSteps { get; set; }

    public virtual DbSet<Envelope> Envelopes { get; set; }

    public virtual DbSet<EnvelopeAddressingStyle> EnvelopeAddressingStyles { get; set; }

    public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

    public virtual DbSet<ExactTargetEmail> ExactTargetEmails { get; set; }

    public virtual DbSet<ExactTargetEmailApiObject> ExactTargetEmailApiObjects { get; set; }

    public virtual DbSet<ExactTargetEmailRetryInterval> ExactTargetEmailRetryIntervals { get; set; }

    public virtual DbSet<ExactTargetEmailType> ExactTargetEmailTypes { get; set; }

    public virtual DbSet<ExcludedKeyword> ExcludedKeywords { get; set; }

    public virtual DbSet<ExtraPostageOption> ExtraPostageOptions { get; set; }

    public virtual DbSet<FacebookPromo> FacebookPromos { get; set; }

    public virtual DbSet<FaqCategory> FaqCategories { get; set; }

    public virtual DbSet<FaqItem> FaqItems { get; set; }

    public virtual DbSet<FoilDieOption> FoilDieOptions { get; set; }

    public virtual DbSet<FoilProduct> FoilProducts { get; set; }

    public virtual DbSet<FontGroup> FontGroups { get; set; }

    public virtual DbSet<Forecast> Forecasts { get; set; }

    public virtual DbSet<GetCustIsForBusiness> GetCustIsForBusinesses { get; set; }

    public virtual DbSet<GetCustomerGroupingContactPreference> GetCustomerGroupingContactPreferences { get; set; }

    public virtual DbSet<GetCustomerType> GetCustomerTypes { get; set; }

    public virtual DbSet<GetEnvelopePersonalization> GetEnvelopePersonalizations { get; set; }

    public virtual DbSet<GetFoldSpecification> GetFoldSpecifications { get; set; }

    public virtual DbSet<GetHolidayCard> GetHolidayCards { get; set; }

    public virtual DbSet<GetLowestEnvelopePrice> GetLowestEnvelopePrices { get; set; }

    public virtual DbSet<GetLowestPrice> GetLowestPrices { get; set; }

    public virtual DbSet<GetStoreShippingGlobalRate> GetStoreShippingGlobalRates { get; set; }

    public virtual DbSet<GettblOrderInvoice> GettblOrderInvoices { get; set; }

    public virtual DbSet<GoogleProductTypeTranslate> GoogleProductTypeTranslates { get; set; }

    public virtual DbSet<HolidayExcludeEmail> HolidayExcludeEmails { get; set; }

    public virtual DbSet<HtmlContent> HtmlContents { get; set; }

    public virtual DbSet<ImageType> ImageTypes { get; set; }

    public virtual DbSet<ImportedDesignLayout> ImportedDesignLayouts { get; set; }

    public virtual DbSet<ImportedPaperStockFinishMapping> ImportedPaperStockFinishMappings { get; set; }

    public virtual DbSet<ImportedProductDesignMapping> ImportedProductDesignMappings { get; set; }

    public virtual DbSet<ImportedProductMapping> ImportedProductMappings { get; set; }

    public virtual DbSet<ImportedProductTypeMapping> ImportedProductTypeMappings { get; set; }

    public virtual DbSet<InkColorGroup> InkColorGroups { get; set; }

    public virtual DbSet<InkColorGroupInkColor> InkColorGroupInkColors { get; set; }

    public virtual DbSet<IntercomConversation> IntercomConversations { get; set; }

    public virtual DbSet<IntercomConversationPart> IntercomConversationParts { get; set; }

    public virtual DbSet<InventoryMastReportAudit> InventoryMastReportAudits { get; set; }

    public virtual DbSet<LandingPageRotator> LandingPageRotators { get; set; }

    public virtual DbSet<Layout> Layouts { get; set; }

    public virtual DbSet<LayoutIcon> LayoutIcons { get; set; }

    public virtual DbSet<LegacyOrderDetail> LegacyOrderDetails { get; set; }

    public virtual DbSet<LegacyOrderHeader> LegacyOrderHeaders { get; set; }

    public virtual DbSet<LgCompare> LgCompares { get; set; }

    public virtual DbSet<LowestEnvelopePrice> LowestEnvelopePrices { get; set; }

    public virtual DbSet<LowestPrice> LowestPrices { get; set; }

    public virtual DbSet<MarketingForTheTroopsPromotion> MarketingForTheTroopsPromotions { get; set; }

    public virtual DbSet<MarketingFormEntry> MarketingFormEntries { get; set; }

    public virtual DbSet<MasterLayout> MasterLayouts { get; set; }

    public virtual DbSet<MatchBackReport> MatchBackReports { get; set; }

    public virtual DbSet<MatchBackReportsSystemDataProcessed> MatchBackReportsSystemDataProcesseds { get; set; }

    public virtual DbSet<MatchBackReportsUserDatum> MatchBackReportsUserData { get; set; }

    public virtual DbSet<MerchandisingSortingParameter> MerchandisingSortingParameters { get; set; }

    public virtual DbSet<MissingPayment> MissingPayments { get; set; }

    public virtual DbSet<NavDestinationType> NavDestinationTypes { get; set; }

    public virtual DbSet<NavigationMenu> NavigationMenus { get; set; }

    public virtual DbSet<NoTransaction2> NoTransaction2s { get; set; }

    public virtual DbSet<Occasion> Occasions { get; set; }

    public virtual DbSet<OmniturePageContent> OmniturePageContents { get; set; }

    public virtual DbSet<OmnitureProperty> OmnitureProperties { get; set; }

    public virtual DbSet<OmniturePropertyType> OmniturePropertyTypes { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderAdjustment> OrderAdjustments { get; set; }

    public virtual DbSet<OrderAllocationAudit> OrderAllocationAudits { get; set; }

    public virtual DbSet<OrderAttachment> OrderAttachments { get; set; }

    public virtual DbSet<OrderCredit> OrderCredits { get; set; }

    public virtual DbSet<OrderCustomerMetric> OrderCustomerMetrics { get; set; }

    public virtual DbSet<OrderLineArtworkRequest> OrderLineArtworkRequests { get; set; }

    public virtual DbSet<OrderLineBusinessFlagKeyword> OrderLineBusinessFlagKeywords { get; set; }

    public virtual DbSet<OrderLineBusinessFlagLog> OrderLineBusinessFlagLogs { get; set; }

    public virtual DbSet<OrderLineCostPrediction> OrderLineCostPredictions { get; set; }

    public virtual DbSet<OrderLineCredit> OrderLineCredits { get; set; }

    public virtual DbSet<OrderLinePersonalization> OrderLinePersonalizations { get; set; }

    public virtual DbSet<OrderLinePlate> OrderLinePlates { get; set; }

    public virtual DbSet<OrderLock> OrderLocks { get; set; }

    public virtual DbSet<OrderNote> OrderNotes { get; set; }

    public virtual DbSet<OrderNoteEventType> OrderNoteEventTypes { get; set; }

    public virtual DbSet<OrderNotification> OrderNotifications { get; set; }

    public virtual DbSet<OrderNotificationReply> OrderNotificationReplies { get; set; }

    public virtual DbSet<OrderNotificationUser> OrderNotificationUsers { get; set; }

    public virtual DbSet<OrderPaymentAction> OrderPaymentActions { get; set; }

    public virtual DbSet<OrderPaymentAudit> OrderPaymentAudits { get; set; }

    public virtual DbSet<OrderPaymentHistory> OrderPaymentHistories { get; set; }

    public virtual DbSet<OrderStatusFriendly> OrderStatusFriendlies { get; set; }

    public virtual DbSet<OrderTag> OrderTags { get; set; }

    public virtual DbSet<OrderTagKey> OrderTagKeys { get; set; }

    public virtual DbSet<OrderVariableDatum> OrderVariableData { get; set; }

    public virtual DbSet<OrderlineImport> OrderlineImports { get; set; }

    public virtual DbSet<OrderlineMailingAddress> OrderlineMailingAddresses { get; set; }

    public virtual DbSet<OrderlinePersonalizationAudit> OrderlinePersonalizationAudits { get; set; }

    public virtual DbSet<OrderlinePlateFile> OrderlinePlateFiles { get; set; }

    public virtual DbSet<OrderlineSectionProof> OrderlineSectionProofs { get; set; }

    public virtual DbSet<OrderlineStatusAudit> OrderlineStatusAudits { get; set; }

    public virtual DbSet<PackingSlip> PackingSlips { get; set; }

    public virtual DbSet<PageAddRotator> PageAddRotators { get; set; }

    public virtual DbSet<PageAreaContent> PageAreaContents { get; set; }

    public virtual DbSet<PageContent> PageContents { get; set; }

    public virtual DbSet<PageContentEditorMode> PageContentEditorModes { get; set; }

    public virtual DbSet<PageDesignArea> PageDesignAreas { get; set; }

    public virtual DbSet<PageDesignGroup> PageDesignGroups { get; set; }

    public virtual DbSet<PageMasterPage> PageMasterPages { get; set; }

    public virtual DbSet<PageNavigationLink> PageNavigationLinks { get; set; }

    public virtual DbSet<PagePageGroup> PagePageGroups { get; set; }

    public virtual DbSet<PageType> PageTypes { get; set; }

    public virtual DbSet<PaperFinish> PaperFinishes { get; set; }

    public virtual DbSet<PaperStockFinish> PaperStockFinishes { get; set; }

    public virtual DbSet<PaperStockFinishPricingVersion> PaperStockFinishPricingVersions { get; set; }

    public virtual DbSet<PersonalizationLayoutImport> PersonalizationLayoutImports { get; set; }

    public virtual DbSet<PersonalizationTemplateLayoutImport> PersonalizationTemplateLayoutImports { get; set; }

    public virtual DbSet<PersonalizationThumbnail> PersonalizationThumbnails { get; set; }

    public virtual DbSet<PersonalizeImageUpload> PersonalizeImageUploads { get; set; }

    public virtual DbSet<PlateCreationHistory> PlateCreationHistories { get; set; }

    public virtual DbSet<PlateCreationStatus> PlateCreationStatuses { get; set; }

    public virtual DbSet<PopularZipCode> PopularZipCodes { get; set; }

    public virtual DbSet<PreviewVersion> PreviewVersions { get; set; }

    public virtual DbSet<PricingFormula> PricingFormulas { get; set; }

    public virtual DbSet<ProductCategoryHold> ProductCategoryHolds { get; set; }

    public virtual DbSet<ProductCategoryStage> ProductCategoryStages { get; set; }

    public virtual DbSet<ProductCollection> ProductCollections { get; set; }

    public virtual DbSet<ProductColor> ProductColors { get; set; }

    public virtual DbSet<ProductConstructorCode> ProductConstructorCodes { get; set; }

    public virtual DbSet<ProductDesigner> ProductDesigners { get; set; }

    public virtual DbSet<ProductImage> ProductImages { get; set; }

    public virtual DbSet<ProductOccasion> ProductOccasions { get; set; }

    public virtual DbSet<ProductOptionGroup> ProductOptionGroups { get; set; }

    public virtual DbSet<ProductOptionGroupExcludedPaperStockFinish> ProductOptionGroupExcludedPaperStockFinishes { get; set; }

    public virtual DbSet<ProductOptionImage> ProductOptionImages { get; set; }

    public virtual DbSet<ProductOptionPriceGroup> ProductOptionPriceGroups { get; set; }

    public virtual DbSet<ProductOptionPriceGroupDetail> ProductOptionPriceGroupDetails { get; set; }

    public virtual DbSet<ProductOptionType> ProductOptionTypes { get; set; }

    public virtual DbSet<ProductPaperStockFinish> ProductPaperStockFinishes { get; set; }

    public virtual DbSet<ProductProductVariation> ProductProductVariations { get; set; }

    public virtual DbSet<ProductProductVariationSupplierEnvelope> ProductProductVariationSupplierEnvelopes { get; set; }

    public virtual DbSet<ProductRecommendation> ProductRecommendations { get; set; }

    public virtual DbSet<ProductSetupAudit> ProductSetupAudits { get; set; }

    public virtual DbSet<ProductSetupVariationAudit> ProductSetupVariationAudits { get; set; }

    public virtual DbSet<ProductStockRequestsAudit> ProductStockRequestsAudits { get; set; }

    public virtual DbSet<ProductStyle> ProductStyles { get; set; }

    public virtual DbSet<ProductTheme> ProductThemes { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<ProductTypeProduction> ProductTypeProductions { get; set; }

    public virtual DbSet<ProductTypeQuantity> ProductTypeQuantities { get; set; }

    public virtual DbSet<ProductTypeVariation> ProductTypeVariations { get; set; }

    public virtual DbSet<ProductTypeWeight> ProductTypeWeights { get; set; }

    public virtual DbSet<ProductUse> ProductUses { get; set; }

    public virtual DbSet<ProductVariation> ProductVariations { get; set; }

    public virtual DbSet<ProductVariationEnvelope> ProductVariationEnvelopes { get; set; }

    public virtual DbSet<ProductVariationInkColor> ProductVariationInkColors { get; set; }

    public virtual DbSet<ProductVariationMinMaxQuantity> ProductVariationMinMaxQuantities { get; set; }

    public virtual DbSet<ProductVariationOptionGroup> ProductVariationOptionGroups { get; set; }

    public virtual DbSet<ProductVariationPaperStockFinishTemplate> ProductVariationPaperStockFinishTemplates { get; set; }

    public virtual DbSet<ProductVariationSection> ProductVariationSections { get; set; }

    public virtual DbSet<ProductVariationSectionBackup> ProductVariationSectionBackups { get; set; }

    public virtual DbSet<ProductVariationSectionFold> ProductVariationSectionFolds { get; set; }

    public virtual DbSet<ProductVariationSectionLayout> ProductVariationSectionLayouts { get; set; }

    public virtual DbSet<ProductVariationSectionLayoutTemplate> ProductVariationSectionLayoutTemplates { get; set; }

    public virtual DbSet<ProductVariationSectionPlate> ProductVariationSectionPlates { get; set; }

    public virtual DbSet<ProductVariationSectionTemplate> ProductVariationSectionTemplates { get; set; }

    public virtual DbSet<ProductionHolidaySchedule> ProductionHolidaySchedules { get; set; }

    public virtual DbSet<ProductionType> ProductionTypes { get; set; }

    public virtual DbSet<ProductsToBeImported> ProductsToBeImporteds { get; set; }

    public virtual DbSet<ProductsToMigrate> ProductsToMigrates { get; set; }

    public virtual DbSet<ProductsUpdatedForMerchandiseScore> ProductsUpdatedForMerchandiseScores { get; set; }

    public virtual DbSet<PromoCodeType> PromoCodeTypes { get; set; }

    public virtual DbSet<PromotionalProduct> PromotionalProducts { get; set; }

    public virtual DbSet<ProofSectionMessage> ProofSectionMessages { get; set; }

    public virtual DbSet<ProspectDoNotMail> ProspectDoNotMails { get; set; }

    public virtual DbSet<Pv2sectionImage> Pv2sectionImages { get; set; }

    public virtual DbSet<Pv4browser> Pv4browsers { get; set; }

    public virtual DbSet<RecentlyViewedOrder> RecentlyViewedOrders { get; set; }

    public virtual DbSet<RegisterTaxOrderQueue> RegisterTaxOrderQueues { get; set; }

    public virtual DbSet<RelatedProduct> RelatedProducts { get; set; }

    public virtual DbSet<ReportGetOrderlineCostPredictionView> ReportGetOrderlineCostPredictionViews { get; set; }

    public virtual DbSet<RotatorFeature> RotatorFeatures { get; set; }

    public virtual DbSet<RptOrderPaymentIssue> RptOrderPaymentIssues { get; set; }

    public virtual DbSet<SaleZipCode> SaleZipCodes { get; set; }

    public virtual DbSet<SalesBudgetByDay> SalesBudgetByDays { get; set; }

    public virtual DbSet<SampleKitRequest> SampleKitRequests { get; set; }

    public virtual DbSet<SampleRequestEmailReminder> SampleRequestEmailReminders { get; set; }

    public virtual DbSet<SampleRequestHistory> SampleRequestHistories { get; set; }

    public virtual DbSet<SaveProjectReminder> SaveProjectReminders { get; set; }

    public virtual DbSet<SaveShoppingCartReminder> SaveShoppingCartReminders { get; set; }

    public virtual DbSet<SavedProject> SavedProjects { get; set; }

    public virtual DbSet<SavedProjectImport> SavedProjectImports { get; set; }

    public virtual DbSet<SavedShoppingCart> SavedShoppingCarts { get; set; }

    public virtual DbSet<SearchTermExclusion> SearchTermExclusions { get; set; }

    public virtual DbSet<Section> Sections { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<ServiceFeed> ServiceFeeds { get; set; }

    public virtual DbSet<ServiceMessage> ServiceMessages { get; set; }

    public virtual DbSet<ServiceMessageType> ServiceMessageTypes { get; set; }

    public virtual DbSet<ServiceMonitorLog> ServiceMonitorLogs { get; set; }

    public virtual DbSet<ServiceStatusType> ServiceStatusTypes { get; set; }

    public virtual DbSet<ServiceType> ServiceTypes { get; set; }

    public virtual DbSet<ShareAsaleDatum> ShareAsaleData { get; set; }

    public virtual DbSet<ShippingCostPrediction> ShippingCostPredictions { get; set; }

    public virtual DbSet<ShippingCostPredictionBoxWeight> ShippingCostPredictionBoxWeights { get; set; }

    public virtual DbSet<ShippingCostPredictionVariationWeight> ShippingCostPredictionVariationWeights { get; set; }

    public virtual DbSet<ShippingCostPredictionWeightAudit> ShippingCostPredictionWeightAudits { get; set; }

    public virtual DbSet<ShippingGroup> ShippingGroups { get; set; }

    public virtual DbSet<ShippingGroupSegmentMethod> ShippingGroupSegmentMethods { get; set; }

    public virtual DbSet<ShippingPricingGroup> ShippingPricingGroups { get; set; }

    public virtual DbSet<ShippingSegment> ShippingSegments { get; set; }

    public virtual DbSet<ShippingSegmentDetail> ShippingSegmentDetails { get; set; }

    public virtual DbSet<SiteMap> SiteMaps { get; set; }

    public virtual DbSet<SiteSearch> SiteSearches { get; set; }

    public virtual DbSet<Ssosetting> Ssosettings { get; set; }

    public virtual DbSet<StockArtwork> StockArtworks { get; set; }

    public virtual DbSet<StockArtworkGroup> StockArtworkGroups { get; set; }

    public virtual DbSet<StockArtworkGroupItem> StockArtworkGroupItems { get; set; }

    public virtual DbSet<StockArtworkTree> StockArtworkTrees { get; set; }

    public virtual DbSet<StoreAppsetting> StoreAppsettings { get; set; }

    public virtual DbSet<StoreConfig> StoreConfigs { get; set; }

    public virtual DbSet<StoreEmailReminderSchedule> StoreEmailReminderSchedules { get; set; }

    public virtual DbSet<StoreFont> StoreFonts { get; set; }

    public virtual DbSet<StorePayment> StorePayments { get; set; }

    public virtual DbSet<StoreProductMerchandisingAlgorithm> StoreProductMerchandisingAlgorithms { get; set; }

    public virtual DbSet<StoreProductType> StoreProductTypes { get; set; }

    public virtual DbSet<StoreShippingGlobalRate> StoreShippingGlobalRates { get; set; }

    public virtual DbSet<StoreShippingMethod> StoreShippingMethods { get; set; }

    public virtual DbSet<Style> Styles { get; set; }

    public virtual DbSet<SummedMismatch> SummedMismatches { get; set; }

    public virtual DbSet<SupplierAllocationControl> SupplierAllocationControls { get; set; }

    public virtual DbSet<SupplierAllocationDefaultSupplierByZip> SupplierAllocationDefaultSupplierByZips { get; set; }

    public virtual DbSet<SupplierAllocationEnvelope> SupplierAllocationEnvelopes { get; set; }

    public virtual DbSet<SupplierAllocationFoilDie> SupplierAllocationFoilDies { get; set; }

    public virtual DbSet<SupplierAllocationOption> SupplierAllocationOptions { get; set; }

    public virtual DbSet<SupplierAllocationStart> SupplierAllocationStarts { get; set; }

    public virtual DbSet<SupplierAllocationVariationByStore> SupplierAllocationVariationByStores { get; set; }

    public virtual DbSet<SupplierAllocationZipCodeArea> SupplierAllocationZipCodeAreas { get; set; }

    public virtual DbSet<SupplierCardSizeMapping> SupplierCardSizeMappings { get; set; }

    public virtual DbSet<SupplierConfig> SupplierConfigs { get; set; }

    public virtual DbSet<SupplierEmailExtractor> SupplierEmailExtractors { get; set; }

    public virtual DbSet<SupplierEnvelope> SupplierEnvelopes { get; set; }

    public virtual DbSet<SupplierEnvelopePricing> SupplierEnvelopePricings { get; set; }

    public virtual DbSet<SupplierEnvelopeSection> SupplierEnvelopeSections { get; set; }

    public virtual DbSet<SupplierEnvelopeSectionLayout> SupplierEnvelopeSectionLayouts { get; set; }

    public virtual DbSet<SupplierHandlingCharge> SupplierHandlingCharges { get; set; }

    public virtual DbSet<SupplierOrderInvoiceSchema> SupplierOrderInvoiceSchemas { get; set; }

    public virtual DbSet<SupplierOrderPartAllocationAudit> SupplierOrderPartAllocationAudits { get; set; }

    public virtual DbSet<SupplierOrderStatusCrossRef> SupplierOrderStatusCrossRefs { get; set; }

    public virtual DbSet<SupplierOrderStatusInvalidPo> SupplierOrderStatusInvalidPos { get; set; }

    public virtual DbSet<SupplierOrderStatusSchema> SupplierOrderStatusSchemas { get; set; }

    public virtual DbSet<SupplierPaperFinishMapping> SupplierPaperFinishMappings { get; set; }

    public virtual DbSet<SupplierPaperStock> SupplierPaperStocks { get; set; }

    public virtual DbSet<SupplierPaperStockMapping> SupplierPaperStockMappings { get; set; }

    public virtual DbSet<SupplierPricingDetail> SupplierPricingDetails { get; set; }

    public virtual DbSet<SupplierProductMapping> SupplierProductMappings { get; set; }

    public virtual DbSet<SupplierProductMappingAudit> SupplierProductMappingAudits { get; set; }

    public virtual DbSet<SupplierProductMappingInventoryTracking> SupplierProductMappingInventoryTrackings { get; set; }

    public virtual DbSet<SupplierProductType> SupplierProductTypes { get; set; }

    public virtual DbSet<SupplierProductTypeMappingByStore> SupplierProductTypeMappingByStores { get; set; }

    public virtual DbSet<SupplierProductionType> SupplierProductionTypes { get; set; }

    public virtual DbSet<SupplierProductsInventory> SupplierProductsInventories { get; set; }

    public virtual DbSet<SupplierStatusDashboard> SupplierStatusDashboards { get; set; }

    public virtual DbSet<SupplierStatusShippingCodeCrossRef> SupplierStatusShippingCodeCrossRefs { get; set; }

    public virtual DbSet<SupplierStockThreshold> SupplierStockThresholds { get; set; }

    public virtual DbSet<SupplierTimeInTransit> SupplierTimeInTransits { get; set; }

    public virtual DbSet<SupplierUpsmaxOrderCount> SupplierUpsmaxOrderCounts { get; set; }

    public virtual DbSet<SupplierVariation> SupplierVariations { get; set; }

    public virtual DbSet<TaxCity> TaxCities { get; set; }

    public virtual DbSet<Taxorder> Taxorders { get; set; }

    public virtual DbSet<TblAlbum> TblAlbums { get; set; }

    public virtual DbSet<TblAlternateEnvelope> TblAlternateEnvelopes { get; set; }

    public virtual DbSet<TblAmountMisMatch> TblAmountMisMatches { get; set; }

    public virtual DbSet<TblArea> TblAreas { get; set; }

    public virtual DbSet<TblAuthorizationAvscode> TblAuthorizationAvscodes { get; set; }

    public virtual DbSet<TblAuthorizationBankAccountType> TblAuthorizationBankAccountTypes { get; set; }

    public virtual DbSet<TblAuthorizationCardCode> TblAuthorizationCardCodes { get; set; }

    public virtual DbSet<TblAuthorizationEcheckType> TblAuthorizationEcheckTypes { get; set; }

    public virtual DbSet<TblAuthorizationResponseCode> TblAuthorizationResponseCodes { get; set; }

    public virtual DbSet<TblAuthorizationResponseReasonCode> TblAuthorizationResponseReasonCodes { get; set; }

    public virtual DbSet<TblAuthorizationTransactionType> TblAuthorizationTransactionTypes { get; set; }

    public virtual DbSet<TblBasket> TblBaskets { get; set; }

    public virtual DbSet<TblBasketItem> TblBasketItems { get; set; }

    public virtual DbSet<TblBatchTransmission> TblBatchTransmissions { get; set; }

    public virtual DbSet<TblBatchTransmissionsOrderPart> TblBatchTransmissionsOrderParts { get; set; }

    public virtual DbSet<TblCardDetailInitialization> TblCardDetailInitializations { get; set; }

    public virtual DbSet<TblCarlsonCraftOsrshipMethod> TblCarlsonCraftOsrshipMethods { get; set; }

    public virtual DbSet<TblCatalog> TblCatalogs { get; set; }

    public virtual DbSet<TblChristmasCard> TblChristmasCards { get; set; }

    public virtual DbSet<TblChristmasCardsOrderLineCustomText> TblChristmasCardsOrderLineCustomTexts { get; set; }

    public virtual DbSet<TblCompanyDepartment> TblCompanyDepartments { get; set; }

    public virtual DbSet<TblCompanyEmployee> TblCompanyEmployees { get; set; }

    public virtual DbSet<TblCompanyEmployeeStatus> TblCompanyEmployeeStatuses { get; set; }

    public virtual DbSet<TblCompanyEmployeeUserGroup> TblCompanyEmployeeUserGroups { get; set; }

    public virtual DbSet<TblCounter> TblCounters { get; set; }

    public virtual DbSet<TblCountry> TblCountries { get; set; }

    public virtual DbSet<TblCoupon> TblCoupons { get; set; }

    public virtual DbSet<TblCouponDiscount> TblCouponDiscounts { get; set; }

    public virtual DbSet<TblCreditCardType> TblCreditCardTypes { get; set; }

    public virtual DbSet<TblCustomTextTemplate> TblCustomTextTemplates { get; set; }

    public virtual DbSet<TblCustomTextTemplateGroup> TblCustomTextTemplateGroups { get; set; }

    public virtual DbSet<TblCustomTextTemplateLine> TblCustomTextTemplateLines { get; set; }

    public virtual DbSet<TblCustomer> TblCustomers { get; set; }

    public virtual DbSet<TblCustomerAddress> TblCustomerAddresses { get; set; }

    public virtual DbSet<TblCustomerCatalogRequest> TblCustomerCatalogRequests { get; set; }

    public virtual DbSet<TblCustomerCatalogRequestCatalog> TblCustomerCatalogRequestCatalogs { get; set; }

    public virtual DbSet<TblCustomerCatalogRequestCode> TblCustomerCatalogRequestCodes { get; set; }

    public virtual DbSet<TblCustomerGrouping> TblCustomerGroupings { get; set; }

    public virtual DbSet<TblCustomerProofStatus> TblCustomerProofStatuses { get; set; }

    public virtual DbSet<TblDepartment> TblDepartments { get; set; }

    public virtual DbSet<TblDepartmentProduct> TblDepartmentProducts { get; set; }

    public virtual DbSet<TblDiscount> TblDiscounts { get; set; }

    public virtual DbSet<TblDiscountType> TblDiscountTypes { get; set; }

    public virtual DbSet<TblEnvelopeType> TblEnvelopeTypes { get; set; }

    public virtual DbSet<TblFrontOption> TblFrontOptions { get; set; }

    public virtual DbSet<TblFrontOptionGroup> TblFrontOptionGroups { get; set; }

    public virtual DbSet<TblGraphicColor> TblGraphicColors { get; set; }

    public virtual DbSet<TblGraphicType> TblGraphicTypes { get; set; }

    public virtual DbSet<TblHorizontalAlignmentType> TblHorizontalAlignmentTypes { get; set; }

    public virtual DbSet<TblInkColor> TblInkColors { get; set; }

    public virtual DbSet<TblLayout> TblLayouts { get; set; }

    public virtual DbSet<TblLayoutArea> TblLayoutAreas { get; set; }

    public virtual DbSet<TblLayoutAreaType> TblLayoutAreaTypes { get; set; }

    public virtual DbSet<TblLayoutType> TblLayoutTypes { get; set; }

    public virtual DbSet<TblManufacturer> TblManufacturers { get; set; }

    public virtual DbSet<TblOccasion> TblOccasions { get; set; }

    public virtual DbSet<TblOrderInvoice> TblOrderInvoices { get; set; }

    public virtual DbSet<TblOrderInvoicesOrderLine> TblOrderInvoicesOrderLines { get; set; }

    public virtual DbSet<TblOrderLine> TblOrderLines { get; set; }

    public virtual DbSet<TblOrderLineGraphic> TblOrderLineGraphics { get; set; }

    public virtual DbSet<TblOrderLineLayoutAreaCustomization> TblOrderLineLayoutAreaCustomizations { get; set; }

    public virtual DbSet<TblOrderLineLayoutAreaCustomizationsFrombackup> TblOrderLineLayoutAreaCustomizationsFrombackups { get; set; }

    public virtual DbSet<TblOrderLineStatus> TblOrderLineStatuses { get; set; }

    public virtual DbSet<TblOrderLineSubmission> TblOrderLineSubmissions { get; set; }

    public virtual DbSet<TblOrderLineSubmissionGraphicFile> TblOrderLineSubmissionGraphicFiles { get; set; }

    public virtual DbSet<TblOrderMailedInvoice> TblOrderMailedInvoices { get; set; }

    public virtual DbSet<TblOrderMailedSample> TblOrderMailedSamples { get; set; }

    public virtual DbSet<TblOrderNumberSeed> TblOrderNumberSeeds { get; set; }

    public virtual DbSet<TblOrderPart> TblOrderParts { get; set; }

    public virtual DbSet<TblOrderPartSubmission> TblOrderPartSubmissions { get; set; }

    public virtual DbSet<TblOrderPartsAutoChange> TblOrderPartsAutoChanges { get; set; }

    public virtual DbSet<TblOrderPayment> TblOrderPayments { get; set; }

    public virtual DbSet<TblOrderPaymentMethod> TblOrderPaymentMethods { get; set; }

    public virtual DbSet<TblOrderStatus> TblOrderStatuses { get; set; }

    public virtual DbSet<TblOrderSubmissionStatus> TblOrderSubmissionStatuses { get; set; }

    public virtual DbSet<TblOrderType> TblOrderTypes { get; set; }

    public virtual DbSet<TblOrdersAudit> TblOrdersAudits { get; set; }

    public virtual DbSet<TblOrdersCoupon> TblOrdersCoupons { get; set; }

    public virtual DbSet<TblPaymentStatus> TblPaymentStatuses { get; set; }

    public virtual DbSet<TblPreviousAction> TblPreviousActions { get; set; }

    public virtual DbSet<TblPricingGroup> TblPricingGroups { get; set; }

    public virtual DbSet<TblPrintItem> TblPrintItems { get; set; }

    public virtual DbSet<TblProFu> TblProFus { get; set; }

    public virtual DbSet<TblProduct> TblProducts { get; set; }

    public virtual DbSet<TblProductIdsThatPricingGroupWasModifiedWithCarlsonCraftPriceGroup> TblProductIdsThatPricingGroupWasModifiedWithCarlsonCraftPriceGroups { get; set; }

    public virtual DbSet<TblProductPricingGroupsAudit> TblProductPricingGroupsAudits { get; set; }

    public virtual DbSet<TblProductSimilarProductCode> TblProductSimilarProductCodes { get; set; }

    public virtual DbSet<TblProductStatus> TblProductStatuses { get; set; }

    public virtual DbSet<TblProductType> TblProductTypes { get; set; }

    public virtual DbSet<TblProductionTime> TblProductionTimes { get; set; }

    public virtual DbSet<TblProductsAudit> TblProductsAudits { get; set; }

    public virtual DbSet<TblProductsDtpinvalid> TblProductsDtpinvalids { get; set; }

    public virtual DbSet<TblRedirect> TblRedirects { get; set; }

    public virtual DbSet<TblReprintReason> TblReprintReasons { get; set; }

    public virtual DbSet<TblRole> TblRoles { get; set; }

    public virtual DbSet<TblSampleCardStockOrder> TblSampleCardStockOrders { get; set; }

    public virtual DbSet<TblSampleCardStockOrderLineItem> TblSampleCardStockOrderLineItems { get; set; }

    public virtual DbSet<TblSampleInventoryInitialization> TblSampleInventoryInitializations { get; set; }

    public virtual DbSet<TblSearchTerm> TblSearchTerms { get; set; }

    public virtual DbSet<TblSearchTermRedirect> TblSearchTermRedirects { get; set; }

    public virtual DbSet<TblSession> TblSessions { get; set; }

    public virtual DbSet<TblShippingCarrier> TblShippingCarriers { get; set; }

    public virtual DbSet<TblShippingMethod> TblShippingMethods { get; set; }

    public virtual DbSet<TblShippingMethodLookup> TblShippingMethodLookups { get; set; }

    public virtual DbSet<TblSize> TblSizes { get; set; }

    public virtual DbSet<TblState> TblStates { get; set; }

    public virtual DbSet<Store> TblStores { get; set; }

    public virtual DbSet<TblStoreDepartment> TblStoreDepartments { get; set; }

    public virtual DbSet<TblStoreDepartmentCategory> TblStoreDepartmentCategories { get; set; }

    public virtual DbSet<TblStoreProduct> TblStoreProducts { get; set; }

    public virtual DbSet<TblStoreProductVisit> TblStoreProductVisits { get; set; }

    public virtual DbSet<TblStoreProductsBak> TblStoreProductsBaks { get; set; }

    public virtual DbSet<TblStoreRetailDiscount> TblStoreRetailDiscounts { get; set; }

    public virtual DbSet<TblStoreSupplier> TblStoreSuppliers { get; set; }

    public virtual DbSet<TblStoreSupplierRetailDiscount> TblStoreSupplierRetailDiscounts { get; set; }

    public virtual DbSet<TblStoreSupplierRetailDiscountsAudit> TblStoreSupplierRetailDiscountsAudits { get; set; }

    public virtual DbSet<TblStoreSuppliersIcsmxmlToid> TblStoreSuppliersIcsmxmlToids { get; set; }

    public virtual DbSet<TblSuggestedWording> TblSuggestedWordings { get; set; }

    public virtual DbSet<TblSupplier> TblSuppliers { get; set; }

    public virtual DbSet<TblSupplierEnvelope> TblSupplierEnvelopes { get; set; }

    public virtual DbSet<TblSupplierEnvelopesPricingVersion> TblSupplierEnvelopesPricingVersions { get; set; }

    public virtual DbSet<TblSupplierInkColor> TblSupplierInkColors { get; set; }

    public virtual DbSet<TblSupplierManufacturerCode> TblSupplierManufacturerCodes { get; set; }

    public virtual DbSet<TblSupplierPricing> TblSupplierPricings { get; set; }

    public virtual DbSet<TblSupplierProductsStock> TblSupplierProductsStocks { get; set; }

    public virtual DbSet<TblSupplierProductsStockOrdered> TblSupplierProductsStockOrdereds { get; set; }

    public virtual DbSet<TblSupplierState> TblSupplierStates { get; set; }

    public virtual DbSet<TblSupplierStockBatch> TblSupplierStockBatches { get; set; }

    public virtual DbSet<TblTypestyle> TblTypestyles { get; set; }

    public virtual DbSet<TblTypestyleGroup> TblTypestyleGroups { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    public virtual DbSet<TblUserDepartment> TblUserDepartments { get; set; }

    public virtual DbSet<TblUserRole> TblUserRoles { get; set; }

    public virtual DbSet<TblVerse> TblVerses { get; set; }

    public virtual DbSet<TblVerseGroup> TblVerseGroups { get; set; }

    public virtual DbSet<TblVerseMode> TblVerseModes { get; set; }

    public virtual DbSet<TblVerticalAlignmentType> TblVerticalAlignmentTypes { get; set; }

    public virtual DbSet<TestBaseProductPricingInfo> TestBaseProductPricingInfos { get; set; }

    public virtual DbSet<Testimonial> Testimonials { get; set; }

    public virtual DbSet<Theme> Themes { get; set; }

    public virtual DbSet<TmpProductsStockRequest> TmpProductsStockRequests { get; set; }

    public virtual DbSet<TmptblCatalogRequestsLabel> TmptblCatalogRequestsLabels { get; set; }

    public virtual DbSet<UspsorderLine> UspsorderLines { get; set; }

    public virtual DbSet<VActiveProduct> VActiveProducts { get; set; }

    public virtual DbSet<VActiveProductsWithSevenDayAverage> VActiveProductsWithSevenDayAverages { get; set; }

    public virtual DbSet<VAssortmentPack> VAssortmentPacks { get; set; }

    public virtual DbSet<VAssortmentPackProduct> VAssortmentPackProducts { get; set; }

    public virtual DbSet<VAutoProcessOrder> VAutoProcessOrders { get; set; }

    public virtual DbSet<VAutoProcessablePreviewOrder> VAutoProcessablePreviewOrders { get; set; }

    public virtual DbSet<VAutoTriggerDatum> VAutoTriggerData { get; set; }

    public virtual DbSet<VCalendarCard> VCalendarCards { get; set; }

    public virtual DbSet<VCompletedOrderLine> VCompletedOrderLines { get; set; }

    public virtual DbSet<VMinimumOrderdatum> VMinimumOrderdata { get; set; }

    public virtual DbSet<VOrderDatum> VOrderData { get; set; }

    public virtual DbSet<VOrderLineStatus> VOrderLineStatuses { get; set; }

    public virtual DbSet<VOrderLinesThatNeedPlatesCreated> VOrderLinesThatNeedPlatesCreateds { get; set; }

    public virtual DbSet<VOrderLinesWithPlateError> VOrderLinesWithPlateErrors { get; set; }

    public virtual DbSet<VOrderQuanityByOrderLineId> VOrderQuanityByOrderLineIds { get; set; }

    public virtual DbSet<VOrderQuantity> VOrderQuantities { get; set; }

    public virtual DbSet<VOrdersOneOpenCreditCardPayment> VOrdersOneOpenCreditCardPayments { get; set; }

    public virtual DbSet<VOrdersWithAllNonPreviewOrderLine> VOrdersWithAllNonPreviewOrderLines { get; set; }

    public virtual DbSet<VOrdersWithAllOrderLinesAssortmentPack> VOrdersWithAllOrderLinesAssortmentPacks { get; set; }

    public virtual DbSet<VOrdersWithAllOrderLinesNewOrderStatus> VOrdersWithAllOrderLinesNewOrderStatuses { get; set; }

    public virtual DbSet<VOrdersWithNoProofRevisionInstruction> VOrdersWithNoProofRevisionInstructions { get; set; }

    public virtual DbSet<VOrdersWithNoSpecialInstruction> VOrdersWithNoSpecialInstructions { get; set; }

    public virtual DbSet<VOrdersWithoutArtwork> VOrdersWithoutArtworks { get; set; }

    public virtual DbSet<VOrdersWithoutImprintLessThan30DaysOld> VOrdersWithoutImprintLessThan30DaysOlds { get; set; }

    public virtual DbSet<VProductAlternateEnvelope> VProductAlternateEnvelopes { get; set; }

    public virtual DbSet<VProductConfiguration> VProductConfigurations { get; set; }

    public virtual DbSet<VSupplierOrderShippingMethod> VSupplierOrderShippingMethods { get; set; }

    public virtual DbSet<VSupplierOrderStatusCrossRef> VSupplierOrderStatusCrossRefs { get; set; }

    public virtual DbSet<VUnGroupedCustomer> VUnGroupedCustomers { get; set; }

    public virtual DbSet<VVariationPricingGroupDefault> VVariationPricingGroupDefaults { get; set; }

    public virtual DbSet<ValidatedAddress> ValidatedAddresses { get; set; }

    public virtual DbSet<VariationPriceGroupQuantity> VariationPriceGroupQuantities { get; set; }

    public virtual DbSet<VariationPricingGroup> VariationPricingGroups { get; set; }

    public virtual DbSet<VariationPricingGroupDefault> VariationPricingGroupDefaults { get; set; }

    public virtual DbSet<VariationPricingGroupMapping> VariationPricingGroupMappings { get; set; }

    public virtual DbSet<VariationShippingGroup> VariationShippingGroups { get; set; }

    public virtual DbSet<VariationSizeMapping> VariationSizeMappings { get; set; }

    public virtual DbSet<VertexProductCode> VertexProductCodes { get; set; }

    public virtual DbSet<ViewActiveSupplier> ViewActiveSuppliers { get; set; }

    public virtual DbSet<ViewAutoCompleteTextForIndex> ViewAutoCompleteTextForIndices { get; set; }

    public virtual DbSet<ViewDiscountSchedule> ViewDiscountSchedules { get; set; }

    public virtual DbSet<ViewDpcardSize> ViewDpcardSizes { get; set; }

    public virtual DbSet<ViewDporderLine> ViewDporderLines { get; set; }

    public virtual DbSet<ViewDppv2orderLine> ViewDppv2orderLines { get; set; }

    public virtual DbSet<ViewDppv3orderLine> ViewDppv3orderLines { get; set; }

    public virtual DbSet<ViewDppv3orderLinesRaw> ViewDppv3orderLinesRaws { get; set; }

    public virtual DbSet<ViewInkColorGroup> ViewInkColorGroups { get; set; }

    public virtual DbSet<ViewOrderCustomerCreditInfo> ViewOrderCustomerCreditInfos { get; set; }

    public virtual DbSet<ViewOrderCustomerCreditInfo2> ViewOrderCustomerCreditInfo2s { get; set; }

    public virtual DbSet<ViewOrderNotificationStatus> ViewOrderNotificationStatuses { get; set; }

    public virtual DbSet<ViewOrderSummation> ViewOrderSummations { get; set; }

    public virtual DbSet<ViewPaperStockFinish> ViewPaperStockFinishes { get; set; }

    public virtual DbSet<ViewPreconvertedSupplierInventory> ViewPreconvertedSupplierInventories { get; set; }

    public virtual DbSet<ViewProductAvailableEnvelope> ViewProductAvailableEnvelopes { get; set; }

    public virtual DbSet<ViewProductBasePricing> ViewProductBasePricings { get; set; }

    public virtual DbSet<ViewProductFilter> ViewProductFilters { get; set; }

    public virtual DbSet<ViewProductSampleWithNoPlate> ViewProductSampleWithNoPlates { get; set; }

    public virtual DbSet<ViewPv3recycledProduct> ViewPv3recycledProducts { get; set; }

    public virtual DbSet<VwDashboardShipdate> VwDashboardShipdates { get; set; }

    public virtual DbSet<VwDashboardShipdatesSettlement> VwDashboardShipdatesSettlements { get; set; }

    public virtual DbSet<VwDiscountGroup> VwDiscountGroups { get; set; }

    public virtual DbSet<VwOrdersRegular> VwOrdersRegulars { get; set; }

    public virtual DbSet<VwRootDepartmentName> VwRootDepartmentNames { get; set; }

    public virtual DbSet<VwSalesByDate> VwSalesByDates { get; set; }

    public virtual DbSet<VwSalesByDateAndOrder> VwSalesByDateAndOrders { get; set; }

    public virtual DbSet<VwSalesByDateAndOrder2> VwSalesByDateAndOrder2s { get; set; }

    public virtual DbSet<VwSalesByDateAndOrderExtended> VwSalesByDateAndOrderExtendeds { get; set; }

    public virtual DbSet<WebPageTheme> WebPageThemes { get; set; }

    public virtual DbSet<WordAbbreviation> WordAbbreviations { get; set; }

    public virtual DbSet<ZipCodeNew> ZipCodeNews { get; set; }

    public virtual DbSet<ZipcodeLookup> ZipcodeLookups { get; set; }

    public virtual DbSet<_123printGoogleAnalyticsSearchDatum> _123printGoogleAnalyticsSearchData { get; set; }

    public virtual DbSet<_123printPastedFlatTableResult> _123printPastedFlatTableResults { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=sql-ddm-rize-qa-cus-001.database.windows.net,1433;Initial Catalog=rizeqa;uid=RizeQADeveloper;pwd=3qgTGW$jq08H$L;Pooling=False;Connection Timeout=30000;MultipleActiveResultSets=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
