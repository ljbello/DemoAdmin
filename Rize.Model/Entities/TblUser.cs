using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblUser
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleInitial { get; set; }

    public string LastName { get; set; } = null!;

    public string Initials { get; set; } = null!;

    public string? Username { get; set; }

    public string? Password { get; set; }

    public bool? Active { get; set; }

    public int DepartmentId { get; set; }

    public string? Notes { get; set; }

    public DateTime? DateHired { get; set; }

    public DateTime DateCreated { get; set; }

    public Guid Rowguid { get; set; }

    public string? NtuserName { get; set; }

    public Guid? SessionId { get; set; }

    public string? EmailAddress { get; set; }

    public Guid? PasswordResetToken { get; set; }

    public DateTime? PasswordResetRequestDate { get; set; }

    public int EmployeeId { get; set; }

    public DateTime? LastLogin { get; set; }

    public string? SharedSessionId { get; set; }

    public int? TwoFormAuthCode { get; set; }

    public DateTime? TwoFormAuthCreatedDate { get; set; }

    public int AttemptCount { get; set; }

    public DateTime? LockoutEndDate { get; set; }

    public bool TwoFormAuthEnabled { get; set; }

    public bool InEmployeeLogin { get; set; }

    public int ForgotPasswordRequests { get; set; }

    public DateTime? LastForgotPasswordRequestDate { get; set; }

    public virtual ICollection<AdminPanelLock> AdminPanelLocks { get; set; } = new List<AdminPanelLock>();

    public virtual ICollection<AdminPanelUserPermission> AdminPanelUserPermissions { get; set; } = new List<AdminPanelUserPermission>();

    public virtual ICollection<AdminShortcut> AdminShortcuts { get; set; } = new List<AdminShortcut>();

    public virtual ICollection<AdminTreeNodeUserPermission> AdminTreeNodeUserPermissions { get; set; } = new List<AdminTreeNodeUserPermission>();

    public virtual ICollection<AdminUserRole> AdminUserRoles { get; set; } = new List<AdminUserRole>();

    public virtual ICollection<AdminUserStore> AdminUserStores { get; set; } = new List<AdminUserStore>();

    public virtual ICollection<AmazonProductMapping> AmazonProductMappings { get; set; } = new List<AmazonProductMapping>();

    public virtual ICollection<AutoTrigger> AutoTriggerCreatedByNavigations { get; set; } = new List<AutoTrigger>();

    public virtual ICollection<AutoTrigger> AutoTriggerModifiedByNavigations { get; set; } = new List<AutoTrigger>();

    public virtual ICollection<ColorGroup> ColorGroups { get; set; } = new List<ColorGroup>();

    public virtual ICollection<CustomerProofRequest> CustomerProofRequestCreatedByNavigations { get; set; } = new List<CustomerProofRequest>();

    public virtual ICollection<CustomerProofRequest> CustomerProofRequestSubmittedByNavigations { get; set; } = new List<CustomerProofRequest>();

    public virtual TblUserDepartment Department { get; set; } = null!;

    public virtual ICollection<DiscountGroupSchedule> DiscountGroupSchedules { get; set; } = new List<DiscountGroupSchedule>();

    public virtual ICollection<DiscountGroup> DiscountGroups { get; set; } = new List<DiscountGroup>();

    public virtual ICollection<EmailLog> EmailLogs { get; set; } = new List<EmailLog>();

    public virtual ICollection<EmailTemplate> EmailTemplateCreatedByNavigations { get; set; } = new List<EmailTemplate>();

    public virtual ICollection<EmailTemplate> EmailTemplateModifiedByNavigations { get; set; } = new List<EmailTemplate>();

    public virtual ICollection<EmailTypeStore> EmailTypeStoreCreatedByNavigations { get; set; } = new List<EmailTypeStore>();

    public virtual ICollection<EmailTypeStore> EmailTypeStoreModifiedByNavigations { get; set; } = new List<EmailTypeStore>();

    public virtual ICollection<EmailType> EmailTypes { get; set; } = new List<EmailType>();

    public virtual TblCompanyEmployee Employee { get; set; } = null!;

    public virtual ICollection<ExactTargetEmail> ExactTargetEmails { get; set; } = new List<ExactTargetEmail>();

    public virtual ICollection<FaqItem> FaqItemCreatedByNavigations { get; set; } = new List<FaqItem>();

    public virtual ICollection<FaqItem> FaqItemModifiedByNavigations { get; set; } = new List<FaqItem>();

    public virtual ICollection<FoilDieOption> FoilDieOptionCreatedByNavigations { get; set; } = new List<FoilDieOption>();

    public virtual ICollection<FoilDieOption> FoilDieOptionModifiedByNavigations { get; set; } = new List<FoilDieOption>();

    public virtual ICollection<InkColorGroup> InkColorGroups { get; set; } = new List<InkColorGroup>();

    public virtual ICollection<MerchandisingSortingParameter> MerchandisingSortingParameterCreatedByNavigations { get; set; } = new List<MerchandisingSortingParameter>();

    public virtual ICollection<MerchandisingSortingParameter> MerchandisingSortingParameterModifiedByNavigations { get; set; } = new List<MerchandisingSortingParameter>();

    public virtual ICollection<OrderAdjustment> OrderAdjustments { get; set; } = new List<OrderAdjustment>();

    public virtual ICollection<OrderLinePlate> OrderLinePlates { get; set; } = new List<OrderLinePlate>();

    public virtual ICollection<OrderNote> OrderNotes { get; set; } = new List<OrderNote>();

    public virtual ICollection<OrderNotificationReply> OrderNotificationReplies { get; set; } = new List<OrderNotificationReply>();

    public virtual ICollection<OrderNotificationUser> OrderNotificationUsers { get; set; } = new List<OrderNotificationUser>();

    public virtual ICollection<OrderNotification> OrderNotifications { get; set; } = new List<OrderNotification>();

    public virtual ICollection<OrderlineMailingAddress> OrderlineMailingAddresses { get; set; } = new List<OrderlineMailingAddress>();

    public virtual ICollection<PaperStockFinish> PaperStockFinishCreatedByNavigations { get; set; } = new List<PaperStockFinish>();

    public virtual ICollection<PaperStockFinish> PaperStockFinishModifiedByNavigations { get; set; } = new List<PaperStockFinish>();

    public virtual ICollection<PaperStockFinishPricingVersion> PaperStockFinishPricingVersions { get; set; } = new List<PaperStockFinishPricingVersion>();

    public virtual ICollection<ProductConstructorCode> ProductConstructorCodes { get; set; } = new List<ProductConstructorCode>();

    public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();

    public virtual ICollection<ProductOptionPriceGroup> ProductOptionPriceGroupCreatedByNavigations { get; set; } = new List<ProductOptionPriceGroup>();

    public virtual ICollection<ProductOptionPriceGroup> ProductOptionPriceGroupModifiedByNavigations { get; set; } = new List<ProductOptionPriceGroup>();

    public virtual ICollection<ProductOptionType> ProductOptionTypes { get; set; } = new List<ProductOptionType>();

    public virtual ICollection<ProductSetupAudit> ProductSetupAudits { get; set; } = new List<ProductSetupAudit>();

    public virtual ICollection<ProductSetupVariationAudit> ProductSetupVariationAudits { get; set; } = new List<ProductSetupVariationAudit>();

    public virtual ICollection<ProductType> ProductTypes { get; set; } = new List<ProductType>();

    public virtual ICollection<ShippingGroup> ShippingGroups { get; set; } = new List<ShippingGroup>();

    public virtual ICollection<ShippingSegment> ShippingSegmentCreatedByNavigations { get; set; } = new List<ShippingSegment>();

    public virtual ICollection<ShippingSegment> ShippingSegmentModifiedByNavigations { get; set; } = new List<ShippingSegment>();

    public virtual ICollection<StockArtworkGroupItem> StockArtworkGroupItems { get; set; } = new List<StockArtworkGroupItem>();

    public virtual ICollection<StockArtworkGroup> StockArtworkGroups { get; set; } = new List<StockArtworkGroup>();

    public virtual ICollection<SupplierConfig> SupplierConfigCreatedByNavigations { get; set; } = new List<SupplierConfig>();

    public virtual ICollection<SupplierConfig> SupplierConfigModifiedByNavigations { get; set; } = new List<SupplierConfig>();

    public virtual ICollection<SupplierProductType> SupplierProductTypes { get; set; } = new List<SupplierProductType>();

    public virtual ICollection<SupplierStockThreshold> SupplierStockThresholds { get; set; } = new List<SupplierStockThreshold>();

    public virtual ICollection<TblBatchTransmission> TblBatchTransmissions { get; set; } = new List<TblBatchTransmission>();

    public virtual ICollection<TblCatalog> TblCatalogs { get; set; } = new List<TblCatalog>();

    public virtual ICollection<TblInkColor> TblInkColors { get; set; } = new List<TblInkColor>();

    public virtual ICollection<TblOrderLine> TblOrderLineCreatedByNavigations { get; set; } = new List<TblOrderLine>();

    public virtual ICollection<TblOrderLine> TblOrderLineModifiedByNavigations { get; set; } = new List<TblOrderLine>();

    public virtual ICollection<TblOrderPayment> TblOrderPaymentCreatedByNavigations { get; set; } = new List<TblOrderPayment>();

    public virtual ICollection<TblOrderPayment> TblOrderPaymentModifiedByNavigations { get; set; } = new List<TblOrderPayment>();

    public virtual ICollection<TblPricingGroup> TblPricingGroups { get; set; } = new List<TblPricingGroup>();

    public virtual ICollection<TblRedirect> TblRedirectCreatedByNavigations { get; set; } = new List<TblRedirect>();

    public virtual ICollection<TblRedirect> TblRedirectModifiedByNavigations { get; set; } = new List<TblRedirect>();

    public virtual ICollection<TblStoreSupplierRetailDiscount> TblStoreSupplierRetailDiscounts { get; set; } = new List<TblStoreSupplierRetailDiscount>();

    public virtual ICollection<TblSupplierEnvelopesPricingVersion> TblSupplierEnvelopesPricingVersions { get; set; } = new List<TblSupplierEnvelopesPricingVersion>();

    public virtual ICollection<TblSupplierPricing> TblSupplierPricings { get; set; } = new List<TblSupplierPricing>();

    public virtual ICollection<TblVerse> TblVerses { get; set; } = new List<TblVerse>();

    public virtual ICollection<VariationPricingGroup> VariationPricingGroupCreatedByNavigations { get; set; } = new List<VariationPricingGroup>();

    public virtual ICollection<VariationPricingGroupDefault> VariationPricingGroupDefaults { get; set; } = new List<VariationPricingGroupDefault>();

    public virtual ICollection<VariationPricingGroupMapping> VariationPricingGroupMappings { get; set; } = new List<VariationPricingGroupMapping>();

    public virtual ICollection<VariationPricingGroup> VariationPricingGroupModifiedByNavigations { get; set; } = new List<VariationPricingGroup>();
}
