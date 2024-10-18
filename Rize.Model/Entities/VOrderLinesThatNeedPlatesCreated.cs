using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VOrderLinesThatNeedPlatesCreated
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

    public decimal? OrdAdjustment { get; set; }

    public bool OrdOnHold { get; set; }

    public decimal? OrdSubTotalInvoice { get; set; }

    public string? OrdInvoiceNumber { get; set; }

    public DateTime? OrdInvoiceDate { get; set; }

    public int OrdTypOrderTypeId { get; set; }

    public string? OrdPromotionCode { get; set; }

    public int? BasBasketId { get; set; }

    public decimal? OrdAdditionalDiscountTotal { get; set; }

    public string OrdAdjustmentDescription { get; set; } = null!;

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

    public bool PaymentFailed { get; set; }

    public int? CusCatReqCustomerCatalogRequestId { get; set; }

    public int? OrdOrderIdSampleRequest { get; set; }

    public bool OrdWaitingForInfo { get; set; }

    public bool OrdQuestionForCustomer { get; set; }

    public bool OrdProof { get; set; }

    public bool OrdReprint { get; set; }

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

    public int ArtworkStatusId { get; set; }

    public bool OrdLinArtworkCompleted { get; set; }

    public int? OrdLinCompanyEmployeeIdArtworkAssigned { get; set; }

    public int? OrdLinReferenceProductId { get; set; }

    public int? RepReaReprintReasonId { get; set; }

    public int? OrdLinPreviewVersion { get; set; }

    public string? PersonalizationXml { get; set; }

    public bool? Created { get; set; }

    public bool? PlateError { get; set; }

    public string? PlateErrorMessage { get; set; }
}
