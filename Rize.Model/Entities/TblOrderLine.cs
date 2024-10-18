using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrderLine
{
    public int OrdLinOrderLineId { get; set; }

    public int ParOrderPartId { get; set; }

    public int ProProductId { get; set; }

    public int OrdLinQuantity { get; set; }

    public decimal? OrdLinPriceEach { get; set; }

    public decimal OrdLinPreDiscountDollarAmount { get; set; }

    public DateTime? OrdLinDateTimeChanged { get; set; }

    public string? OrdLinChangedBy { get; set; }

    public string? OrdLinSpecialInstructions { get; set; }

    public decimal OrdLinDiscountDollarAmount { get; set; }

    public decimal OrdLinSubtotalDollarAmount { get; set; }

    public bool OrdLinOutOfStock { get; set; }

    public DateTime? OrdLinStockExpectedDate { get; set; }

    public DateTime? OrdLinOutOfStockNoticeSentDate { get; set; }

    public DateTime? OrdLinDateSubmitted { get; set; }

    public bool OrdLinFollowUpWithSupplier { get; set; }

    public int? OrdStaOrderStatusId { get; set; }

    public int? ShiCarShippingCarrierId { get; set; }

    public int? ShiMetShippingMethodId { get; set; }

    public string? OrdLinShippingTrackingNumber { get; set; }

    public DateTime? OrdLinShipDate { get; set; }

    public DateTime? OrdLinShippingConfirmationSentDate { get; set; }

    public bool OrdLinWaitingOnProof { get; set; }

    public DateTime? OrdLinProofGenerated { get; set; }

    public DateTime? OrdLinProofNoticeSent { get; set; }

    public DateTime? OrdLinProofBadArtworkSent { get; set; }

    public int? OrdLinOrderFormPart { get; set; }

    public int? OrdLinDtppart { get; set; }

    public bool OrdLinLogo { get; set; }

    public bool OrdLinPhoto { get; set; }

    public bool OrdLinArtworkCompleted { get; set; }

    public int? OrdLinCompanyEmployeeIdArtworkAssigned { get; set; }

    public int? OrdLinReferenceProductId { get; set; }

    public int? RepReaReprintReasonId { get; set; }

    public int? OrdLinPreviewVersion { get; set; }

    public string? OrdLinCustomerArtworkId { get; set; }

    public Guid? OrdLinInvoiceId { get; set; }

    public int? SupPriPricingGroupId { get; set; }

    public int? PriGroPricingGroupId { get; set; }

    public int? VariationPricingGroupId { get; set; }

    public decimal? ProPrice { get; set; }

    public Guid? DiscountShippingId { get; set; }

    public DateTime? OrderStatusChangeDate { get; set; }

    public DateTime? StatusDelinquencyEmailSentDate { get; set; }

    public bool IsForBusiness { get; set; }

    public Guid? ThumbnailId { get; set; }

    public Guid? PlateThumbnailId { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? ReOrderFromOrderlineId { get; set; }

    public DateTime? EstimatedShipDate { get; set; }

    public int? StoreId { get; set; }

    public bool? IsEnvelopeAddressing { get; set; }

    public bool? IsMailing { get; set; }

    public bool? IsStamping { get; set; }

    public decimal UpgradeFullColorCost { get; set; }

    public decimal UpgradeFoilCost { get; set; }

    public decimal EnvelopePersonalizationCost { get; set; }

    public DateTime? UpsscheduleDeliveryDate { get; set; }

    public DateTime? UpsdeliveredDate { get; set; }

    public DateTime? UpstrackingLastRequestDate { get; set; }

    public int? ReprintFromOrderLineId { get; set; }

    public int EnvelopeQuantity { get; set; }

    public decimal EnvelopeUsstampingAmount { get; set; }

    public int EnvelopeUsstampingQty { get; set; }

    public decimal EnvelopeMailingAmount { get; set; }

    public int EnvelopeMailingQty { get; set; }

    public decimal EnvelopeInternationalStampingAmount { get; set; }

    public int EnvelopeInternationalStampingQty { get; set; }

    public decimal ExtraEnvelopeAmount { get; set; }

    public int ExtraEnvelopeQty { get; set; }

    public int ArtworkStatusId { get; set; }

    public bool FailSubmission { get; set; }

    public string? SubmissionLastError { get; set; }

    public bool PlateFileReplaced { get; set; }

    public int? CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public int EnvAddressUploadCount { get; set; }

    public DateTime? RequestedMailDate { get; set; }

    public string? VerseNumber { get; set; }

    public decimal QuantityDollarAmount { get; set; }

    public int? SupplierEnvelopeId { get; set; }

    public int? InkColorId { get; set; }

    public int? InkColorId2 { get; set; }

    public string? LogoFileName { get; set; }

    public string? LogoFileName2 { get; set; }

    public string? LogoFileNameEnv { get; set; }

    public decimal? VerticalOffset { get; set; }

    public decimal? HorizontalOffset { get; set; }

    public decimal? VerticalOffsetEnv { get; set; }

    public decimal? HorizontalOffsetEnv { get; set; }

    public decimal? Scale { get; set; }

    public decimal? ScaleEnv { get; set; }

    public bool? IsFullColor { get; set; }

    public long? OrderId { get; set; }

    public virtual ArtworkStatus ArtworkStatus { get; set; } = null!;

    public virtual TblUser? CreatedByNavigation { get; set; }

    public virtual DiscountShipping? DiscountShipping { get; set; }

    public virtual TblInkColor? InkColor { get; set; }

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual TblCompanyEmployee? OrdLinCompanyEmployeeIdArtworkAssignedNavigation { get; set; }

    public virtual TblProduct? OrdLinReferenceProduct { get; set; }

    public virtual TblOrderStatus? OrdStaOrderStatus { get; set; }

    public virtual ICollection<OrderLineCredit> OrderLineCredits { get; set; } = new List<OrderLineCredit>();

    public virtual OrderLinePersonalization? OrderLinePersonalization { get; set; }

    public virtual ICollection<OrderLinePlate> OrderLinePlates { get; set; } = new List<OrderLinePlate>();

    public virtual ICollection<OrderNote> OrderNotes { get; set; } = new List<OrderNote>();

    public virtual ICollection<OrderTag> OrderTags { get; set; } = new List<OrderTag>();

    public virtual ICollection<OrderlineMailingAddress> OrderlineMailingAddresses { get; set; } = new List<OrderlineMailingAddress>();

    public virtual ICollection<OrderlineSectionProof> OrderlineSectionProofs { get; set; } = new List<OrderlineSectionProof>();

    public virtual TblOrderPart ParOrderPart { get; set; } = null!;

    public virtual TblProduct ProProduct { get; set; } = null!;

    public virtual ICollection<ProofSectionMessage> ProofSectionMessages { get; set; } = new List<ProofSectionMessage>();

    public virtual TblReprintReason? RepReaReprintReason { get; set; }

    public virtual TblShippingCarrier? ShiCarShippingCarrier { get; set; }

    public virtual TblShippingMethod? ShiMetShippingMethod { get; set; }

    public virtual TblSupplierEnvelope? SupplierEnvelope { get; set; }

    public virtual ICollection<TblChristmasCardsOrderLineCustomText> TblChristmasCardsOrderLineCustomTexts { get; set; } = new List<TblChristmasCardsOrderLineCustomText>();

    public virtual ICollection<TblOrderLineLayoutAreaCustomization> TblOrderLineLayoutAreaCustomizations { get; set; } = new List<TblOrderLineLayoutAreaCustomization>();

    public virtual ICollection<TblOrderLineStatus> TblOrderLineStatuses { get; set; } = new List<TblOrderLineStatus>();
}
