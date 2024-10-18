using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VOrderDatum
{
    public int OrdOrderId { get; set; }

    public string? OrderNumber { get; set; }

    public int CusCustomerId { get; set; }

    public int OrdBillingAddressId { get; set; }

    public int OrdShippingAddressId { get; set; }

    public DateTime OrdCreatedDate { get; set; }

    public DateTime? OrdCompletedDate { get; set; }

    public bool? OrdCallForCreditCardInfo { get; set; }

    public string? OrdSpecialInstructions { get; set; }

    public decimal? OrdSubTotal { get; set; }

    public decimal? OrdTaxTotal { get; set; }

    public decimal? OrdShippingTotal { get; set; }

    public decimal? OrdOrderTotal { get; set; }

    public bool OrdOnHold { get; set; }

    public decimal? OrdSubTotalInvoice { get; set; }

    public string? OrdInvoiceNumber { get; set; }

    public DateTime? OrdInvoiceDate { get; set; }

    public int OrdTypOrderTypeId { get; set; }

    public string? OrdPromotionCode { get; set; }

    public int? BasBasketId { get; set; }

    public decimal? OrdAdditionalDiscountTotal { get; set; }

    public DateTime? OrdPaymentDeclinedSent { get; set; }

    public DateTime? OrdOrderConfirmationSent { get; set; }

    public DateTime? OrdOrderInvoiceGenerated { get; set; }

    public DateTime? OrdOrderInvoiceSent { get; set; }

    public string? OrdEnteredBy { get; set; }

    public DateTime? OrdPlacedDate { get; set; }

    public string? OrdOrderGuid { get; set; }

    public decimal OrdPreAdditionalDiscountTotal { get; set; }

    public bool OrdTaxable { get; set; }

    public DateTime? OrdPaperInvoiceDate { get; set; }

    public int? CusCatReqCustomerCatalogRequestId { get; set; }

    public int? OrdOrderIdSampleRequest { get; set; }

    public bool OrdWaitingForInfo { get; set; }

    public bool OrdQuestionForCustomer { get; set; }

    public bool OrdProof { get; set; }

    public bool OrdReprint { get; set; }

    public bool OrdPlateEditRequired { get; set; }

    public Guid? CustomerLoginId { get; set; }

    public Guid? CorporateBillingId { get; set; }

    public string? OrdContactName { get; set; }

    public string? OrdContactLastName { get; set; }

    public string? OrdContactEmail { get; set; }

    public string? OrdContactPhone { get; set; }

    public string? OrdPurchaseOrderNumber { get; set; }

    public string? TaxingStateId { get; set; }

    public decimal? CityTax { get; set; }

    public decimal? CountyTax { get; set; }

    public decimal? StateTax { get; set; }

    public decimal? CityTaxRate { get; set; }

    public decimal? CountyTaxRate { get; set; }

    public decimal? StateTaxRate { get; set; }

    public decimal? DistrictTax { get; set; }

    public decimal? DistrictTaxRate { get; set; }

    public decimal? TotalTaxRate { get; set; }

    public DateTime? RegisterTaxDate { get; set; }

    public bool? YearlyOrderReminder { get; set; }

    public DateOnly? DateOnInvoice { get; set; }

    public DateTime? TblOrdersUpdateDate { get; set; }

    public bool IsTaxExempt { get; set; }

    public decimal? RegisteredTaxTotal { get; set; }

    public bool TaxAdjustments { get; set; }

    public bool Delay { get; set; }

    public decimal? CanadianEntryPreparationFee { get; set; }

    public decimal? CanadianDutiesAndTaxes { get; set; }

    public decimal? CanadaShipping { get; set; }

    public DateTime? DelaySubmitDate { get; set; }

    public decimal SettlementAmount { get; set; }

    public int TblOrdersStoreId { get; set; }

    public short? YearlyOrderReminderPart { get; set; }

    public int? ReprintOrderId { get; set; }

    public bool PaymentFailed { get; set; }

    public int SupSupplierId { get; set; }

    public int OrdLinOrderLineId { get; set; }

    public int ParOrderPartId { get; set; }

    public int ProProductId { get; set; }

    public int OrdLinQuantity { get; set; }

    public decimal? OrdLinPriceEach { get; set; }

    public decimal OrdLinPreDiscountDollarAmount { get; set; }

    public DateTime? OrdLinDateTimeChanged { get; set; }

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

    public int ArtworkStatusId { get; set; }

    public bool OrdLinLogo { get; set; }

    public bool OrdLinPhoto { get; set; }

    public bool OrdLinArtworkCompleted { get; set; }

    public int? OrdLinCompanyEmployeeIdArtworkAssigned { get; set; }

    public int? OrdLinReferenceProductId { get; set; }

    public int? RepReaReprintReasonId { get; set; }

    public int? OrdLinPreviewVersion { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? PlateError { get; set; }

    public string? PlateErrorMessage { get; set; }

    public string? OrdLinCustomerArtworkId { get; set; }

    public Guid? OrdLinInvoiceId { get; set; }

    public int? SupPriPricingGroupId { get; set; }

    public int? PriGroPricingGroupId { get; set; }

    public decimal? ProPrice { get; set; }

    public Guid? DiscountShippingId { get; set; }

    public DateTime? OrderStatusChangeDate { get; set; }

    public DateTime? StatusDelinquencyEmailSentDate { get; set; }

    public bool IsForBusiness { get; set; }

    public Guid? ThumbnailId { get; set; }

    public Guid? PlateThumbnailId { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? TblOrderLinesUpdateDate { get; set; }

    public int? ReOrderFromOrderlineId { get; set; }

    public DateTime? EstimatedShipDate { get; set; }

    public int? TblOrderLinesStoreId { get; set; }

    public bool? IsEnvelopeAddressing { get; set; }

    public int? ReprintFromOrderLineId { get; set; }

    public decimal EnvelopePersonalizationCost { get; set; }

    public bool FailSubmission { get; set; }

    public string OrdStaDescription { get; set; } = null!;

    public string? OrdStaFriendlyDescription { get; set; }
}
