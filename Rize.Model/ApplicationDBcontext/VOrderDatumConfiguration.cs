using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VOrderDatumConfiguration : IEntityTypeConfiguration<VOrderDatum>
{
    public void Configure(EntityTypeBuilder<VOrderDatum> entity)
    {
        entity
                .HasNoKey()
                .ToView("vOrderData");

        entity.Property(e => e.BasBasketId).HasColumnName("Bas__BasketID");
        entity.Property(e => e.CanadaShipping).HasColumnType("money");
        entity.Property(e => e.CanadianDutiesAndTaxes).HasColumnType("money");
        entity.Property(e => e.CanadianEntryPreparationFee).HasColumnType("money");
        entity.Property(e => e.CityTax).HasColumnType("money");
        entity.Property(e => e.CityTaxRate).HasColumnType("money");
        entity.Property(e => e.CountyTax).HasColumnType("money");
        entity.Property(e => e.CountyTaxRate).HasColumnType("money");
        entity.Property(e => e.CreateDate).HasColumnType("datetime");
        entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        entity.Property(e => e.CusCatReqCustomerCatalogRequestId).HasColumnName("CusCatReq__CustomerCatalogRequestID");
        entity.Property(e => e.CusCustomerId).HasColumnName("Cus__CustomerID");
        entity.Property(e => e.DelaySubmitDate).HasColumnType("datetime");
        entity.Property(e => e.DistrictTax).HasColumnType("money");
        entity.Property(e => e.DistrictTaxRate).HasColumnType("money");
        entity.Property(e => e.EnvelopePersonalizationCost).HasColumnType("money");
        entity.Property(e => e.EstimatedShipDate).HasColumnType("datetime");
        entity.Property(e => e.OrdAdditionalDiscountTotal)
                .HasColumnType("money")
                .HasColumnName("Ord__AdditionalDiscountTotal");
        entity.Property(e => e.OrdBillingAddressId).HasColumnName("Ord__BillingAddressID");
        entity.Property(e => e.OrdCallForCreditCardInfo).HasColumnName("Ord__CallForCreditCardInfo");
        entity.Property(e => e.OrdCompletedDate)
                .HasColumnType("datetime")
                .HasColumnName("Ord__CompletedDate");
        entity.Property(e => e.OrdContactEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Ord__ContactEmail");
        entity.Property(e => e.OrdContactLastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ord__ContactLastName");
        entity.Property(e => e.OrdContactName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ord__ContactName");
        entity.Property(e => e.OrdContactPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ord__ContactPhone");
        entity.Property(e => e.OrdCreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Ord__CreatedDate");
        entity.Property(e => e.OrdEnteredBy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Ord__EnteredBy");
        entity.Property(e => e.OrdInvoiceDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ord__InvoiceDate");
        entity.Property(e => e.OrdInvoiceNumber)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Ord__InvoiceNumber");
        entity.Property(e => e.OrdLinArtworkCompleted).HasColumnName("OrdLin__ArtworkCompleted");
        entity.Property(e => e.OrdLinCompanyEmployeeIdArtworkAssigned).HasColumnName("OrdLin__CompanyEmployeeID_ArtworkAssigned");
        entity.Property(e => e.OrdLinCustomerArtworkId)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("OrdLin__CustomerArtworkId");
        entity.Property(e => e.OrdLinDateSubmitted)
                .HasColumnType("smalldatetime")
                .HasColumnName("OrdLin__DateSubmitted");
        entity.Property(e => e.OrdLinDateTimeChanged)
                .HasColumnType("datetime")
                .HasColumnName("OrdLin__DateTimeChanged");
        entity.Property(e => e.OrdLinDiscountDollarAmount)
                .HasColumnType("money")
                .HasColumnName("OrdLin__DiscountDollarAmount");
        entity.Property(e => e.OrdLinDtppart).HasColumnName("OrdLin__DTPPart");
        entity.Property(e => e.OrdLinFollowUpWithSupplier).HasColumnName("OrdLin__FollowUpWithSupplier");
        entity.Property(e => e.OrdLinInvoiceId).HasColumnName("OrdLin__InvoiceId");
        entity.Property(e => e.OrdLinLogo).HasColumnName("OrdLin__Logo");
        entity.Property(e => e.OrdLinOrderFormPart).HasColumnName("OrdLin__OrderFormPart");
        entity.Property(e => e.OrdLinOrderLineId).HasColumnName("OrdLin__OrderLineID");
        entity.Property(e => e.OrdLinOutOfStock).HasColumnName("OrdLin__OutOfStock");
        entity.Property(e => e.OrdLinOutOfStockNoticeSentDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("OrdLin__OutOfStockNoticeSentDate");
        entity.Property(e => e.OrdLinPhoto).HasColumnName("OrdLin__Photo");
        entity.Property(e => e.OrdLinPreDiscountDollarAmount)
                .HasColumnType("money")
                .HasColumnName("OrdLin__PreDiscountDollarAmount");
        entity.Property(e => e.OrdLinPreviewVersion).HasColumnName("OrdLin__PreviewVersion");
        entity.Property(e => e.OrdLinPriceEach)
                .HasColumnType("money")
                .HasColumnName("OrdLin__PriceEach");
        entity.Property(e => e.OrdLinProofBadArtworkSent)
                .HasColumnType("smalldatetime")
                .HasColumnName("OrdLin__ProofBadArtworkSent");
        entity.Property(e => e.OrdLinProofGenerated)
                .HasColumnType("smalldatetime")
                .HasColumnName("OrdLin__ProofGenerated");
        entity.Property(e => e.OrdLinProofNoticeSent)
                .HasColumnType("smalldatetime")
                .HasColumnName("OrdLin__ProofNoticeSent");
        entity.Property(e => e.OrdLinQuantity).HasColumnName("OrdLin__Quantity");
        entity.Property(e => e.OrdLinReferenceProductId).HasColumnName("OrdLin__ReferenceProductID");
        entity.Property(e => e.OrdLinShipDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("OrdLin__ShipDate");
        entity.Property(e => e.OrdLinShippingConfirmationSentDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("OrdLin__ShippingConfirmationSentDate");
        entity.Property(e => e.OrdLinShippingTrackingNumber)
                .HasMaxLength(3000)
                .IsUnicode(false)
                .HasColumnName("OrdLin__ShippingTrackingNumber");
        entity.Property(e => e.OrdLinSpecialInstructions)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("OrdLin__SpecialInstructions");
        entity.Property(e => e.OrdLinStockExpectedDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("OrdLin__StockExpectedDate");
        entity.Property(e => e.OrdLinSubtotalDollarAmount)
                .HasColumnType("money")
                .HasColumnName("OrdLin__SubtotalDollarAmount");
        entity.Property(e => e.OrdLinWaitingOnProof).HasColumnName("OrdLin__WaitingOnProof");
        entity.Property(e => e.OrdOnHold).HasColumnName("Ord__OnHold");
        entity.Property(e => e.OrdOrderConfirmationSent)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ord__OrderConfirmationSent");
        entity.Property(e => e.OrdOrderGuid)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("Ord__OrderGUID");
        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");
        entity.Property(e => e.OrdOrderIdSampleRequest).HasColumnName("Ord__OrderID_SampleRequest");
        entity.Property(e => e.OrdOrderInvoiceGenerated)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ord__OrderInvoiceGenerated");
        entity.Property(e => e.OrdOrderInvoiceSent)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ord__OrderInvoiceSent");
        entity.Property(e => e.OrdOrderTotal)
                .HasColumnType("money")
                .HasColumnName("Ord__OrderTotal");
        entity.Property(e => e.OrdPaperInvoiceDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ord__PaperInvoiceDate");
        entity.Property(e => e.OrdPaymentDeclinedSent)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ord__PaymentDeclinedSent");
        entity.Property(e => e.OrdPlacedDate)
                .HasColumnType("datetime")
                .HasColumnName("Ord__PlacedDate");
        entity.Property(e => e.OrdPlateEditRequired).HasColumnName("Ord__PlateEditRequired");
        entity.Property(e => e.OrdPreAdditionalDiscountTotal)
                .HasColumnType("money")
                .HasColumnName("Ord__PreAdditionalDiscountTotal");
        entity.Property(e => e.OrdPromotionCode)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Ord__PromotionCode");
        entity.Property(e => e.OrdProof).HasColumnName("Ord__Proof");
        entity.Property(e => e.OrdPurchaseOrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ord__PurchaseOrderNumber");
        entity.Property(e => e.OrdQuestionForCustomer).HasColumnName("Ord__QuestionForCustomer");
        entity.Property(e => e.OrdReprint).HasColumnName("Ord__Reprint");
        entity.Property(e => e.OrdShippingAddressId).HasColumnName("Ord__ShippingAddressID");
        entity.Property(e => e.OrdShippingTotal)
                .HasColumnType("money")
                .HasColumnName("Ord__ShippingTotal");
        entity.Property(e => e.OrdSpecialInstructions)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("Ord__SpecialInstructions");
        entity.Property(e => e.OrdStaDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("OrdSta__Description");
        entity.Property(e => e.OrdStaFriendlyDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("OrdSta__FriendlyDescription");
        entity.Property(e => e.OrdStaOrderStatusId).HasColumnName("OrdSta__OrderStatusID");
        entity.Property(e => e.OrdSubTotal)
                .HasColumnType("money")
                .HasColumnName("Ord__SubTotal");
        entity.Property(e => e.OrdSubTotalInvoice)
                .HasColumnType("money")
                .HasColumnName("Ord__SubTotal__Invoice");
        entity.Property(e => e.OrdTaxTotal)
                .HasColumnType("money")
                .HasColumnName("Ord__TaxTotal");
        entity.Property(e => e.OrdTaxable).HasColumnName("Ord__Taxable");
        entity.Property(e => e.OrdTypOrderTypeId).HasColumnName("OrdTyp__OrderTypeID");
        entity.Property(e => e.OrdWaitingForInfo).HasColumnName("Ord__WaitingForInfo");
        entity.Property(e => e.OrderNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.OrderStatusChangeDate).HasColumnType("datetime");
        entity.Property(e => e.ParOrderPartId).HasColumnName("Par__OrderPartID");
        entity.Property(e => e.PlateErrorMessage).IsUnicode(false);
        entity.Property(e => e.PriGroPricingGroupId).HasColumnName("PriGro__PricingGroupID");
        entity.Property(e => e.ProPrice)
                .HasColumnType("money")
                .HasColumnName("Pro__Price");
        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductID");
        entity.Property(e => e.ReOrderFromOrderlineId).HasColumnName("ReOrderFromOrderlineID");
        entity.Property(e => e.RegisterTaxDate).HasColumnType("datetime");
        entity.Property(e => e.RegisteredTaxTotal).HasColumnType("money");
        entity.Property(e => e.RepReaReprintReasonId).HasColumnName("RepRea__ReprintReasonID");
        entity.Property(e => e.SettlementAmount).HasColumnType("money");
        entity.Property(e => e.ShiCarShippingCarrierId).HasColumnName("ShiCar__ShippingCarrierID");
        entity.Property(e => e.ShiMetShippingMethodId).HasColumnName("ShiMet__ShippingMethodID");
        entity.Property(e => e.StateTax).HasColumnType("money");
        entity.Property(e => e.StateTaxRate).HasColumnType("money");
        entity.Property(e => e.StatusDelinquencyEmailSentDate).HasColumnType("datetime");
        entity.Property(e => e.SupPriPricingGroupId).HasColumnName("SupPri__PricingGroupID");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");
        entity.Property(e => e.TaxingStateId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TaxingStateID");
        entity.Property(e => e.TblOrderLinesStoreId).HasColumnName("tblOrderLinesStoreID");
        entity.Property(e => e.TblOrderLinesUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("tblOrderLinesUpdateDate");
        entity.Property(e => e.TblOrdersStoreId).HasColumnName("tblOrdersStoreID");
        entity.Property(e => e.TblOrdersUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("tblOrdersUpdateDate");
        entity.Property(e => e.TotalTaxRate).HasColumnType("money");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VOrderDatum> entity);
}
