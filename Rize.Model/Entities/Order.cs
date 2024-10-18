using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class Order
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

    public bool? YearlyOrderReminder { get; set; }

    public DateOnly? DateOnInvoice { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool IsTaxExempt { get; set; }

    public DateTime? RegisterTaxDate { get; set; }

    public decimal? RegisteredTaxTotal { get; set; }

    public decimal? RegisteredTaxOrderAmount { get; set; }

    public decimal? RegisteredTaxShippingAmount { get; set; }

    public bool TaxAdjustments { get; set; }

    public bool Delay { get; set; }

    public decimal? CanadianEntryPreparationFee { get; set; }

    public decimal? CanadianDutiesAndTaxes { get; set; }

    public decimal? CanadaShipping { get; set; }

    public DateTime? DelaySubmitDate { get; set; }

    public decimal SettlementAmount { get; set; }

    public int StoreId { get; set; }

    public short? YearlyOrderReminderPart { get; set; }

    public int? ReprintOrderId { get; set; }

    public DateTime? OrderReceiptSent { get; set; }

    public int? CreatedBy { get; set; }

    public bool PaymentFailed { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? LargestShipDate { get; set; }

    public string? BuyerPersona { get; set; }

    public virtual ICollection<OrderAdjustment> OrderAdjustments { get; set; } = new List<OrderAdjustment>();

    public virtual ICollection<OrderCredit> OrderCredits { get; set; } = new List<OrderCredit>();

    public virtual ICollection<OrderLinePlate> OrderLinePlates { get; set; } = new List<OrderLinePlate>();

    public virtual ICollection<OrderNote> OrderNotes { get; set; } = new List<OrderNote>();

    public virtual ICollection<OrderNotification> OrderNotifications { get; set; } = new List<OrderNotification>();

    public virtual ICollection<OrderTag> OrderTags { get; set; } = new List<OrderTag>();

    public virtual ICollection<SavedShoppingCart> SavedShoppingCarts { get; set; } = new List<SavedShoppingCart>();

    public virtual ICollection<TblBatchTransmissionsOrderPart> TblBatchTransmissionsOrderParts { get; set; } = new List<TblBatchTransmissionsOrderPart>();

    public virtual ICollection<TblOrderInvoice> TblOrderInvoices { get; set; } = new List<TblOrderInvoice>();

    public virtual ICollection<TblOrderMailedInvoice> TblOrderMailedInvoices { get; set; } = new List<TblOrderMailedInvoice>();

    public virtual ICollection<TblOrderMailedSample> TblOrderMailedSamples { get; set; } = new List<TblOrderMailedSample>();

    public virtual ICollection<TblOrderPart> TblOrderParts { get; set; } = new List<TblOrderPart>();

    public virtual ICollection<TblOrderPayment> TblOrderPayments { get; set; } = new List<TblOrderPayment>();

    public virtual ICollection<TblOrdersCoupon> TblOrdersCoupons { get; set; } = new List<TblOrdersCoupon>();
}
