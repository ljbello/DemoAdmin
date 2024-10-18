using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VOrderLinesThatNeedPlatesCreatedConfiguration : IEntityTypeConfiguration<VOrderLinesThatNeedPlatesCreated>
{
    public void Configure(EntityTypeBuilder<VOrderLinesThatNeedPlatesCreated> entity)
    {
        entity
                .HasNoKey()
                .ToView("vOrderLinesThatNeedPlatesCreated");

        entity.Property(e => e.BasBasketId).HasColumnName("Bas__BasketID");
        entity.Property(e => e.CusCatReqCustomerCatalogRequestId).HasColumnName("CusCatReq__CustomerCatalogRequestID");
        entity.Property(e => e.CusCustomerId).HasColumnName("Cus__CustomerID");
        entity.Property(e => e.OrdAdditionalDiscountTotal)
                .HasColumnType("money")
                .HasColumnName("Ord__AdditionalDiscountTotal");
        entity.Property(e => e.OrdAdjustment)
                .HasColumnType("money")
                .HasColumnName("Ord__Adjustment");
        entity.Property(e => e.OrdAdjustmentDescription)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("Ord__AdjustmentDescription");
        entity.Property(e => e.OrdBillingAddressId).HasColumnName("Ord__BillingAddressID");
        entity.Property(e => e.OrdCallForCreditCardInfo).HasColumnName("Ord__CallForCreditCardInfo");
        entity.Property(e => e.OrdCompletedDate)
                .HasColumnType("datetime")
                .HasColumnName("Ord__CompletedDate");
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
        entity.Property(e => e.OrdLinChangedBy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("OrdLin__ChangedBy");
        entity.Property(e => e.OrdLinCompanyEmployeeIdArtworkAssigned).HasColumnName("OrdLin__CompanyEmployeeID_ArtworkAssigned");
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
        entity.Property(e => e.OrdPreAdditionalDiscountTotal)
                .HasColumnType("money")
                .HasColumnName("Ord__PreAdditionalDiscountTotal");
        entity.Property(e => e.OrdPromotionCode)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Ord__PromotionCode");
        entity.Property(e => e.OrdProof).HasColumnName("Ord__Proof");
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
        entity.Property(e => e.ParOrderPartId).HasColumnName("Par__OrderPartID");
        entity.Property(e => e.PersonalizationXml).HasColumnType("xml");
        entity.Property(e => e.PlateErrorMessage).IsUnicode(false);
        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductID");
        entity.Property(e => e.RepReaReprintReasonId).HasColumnName("RepRea__ReprintReasonID");
        entity.Property(e => e.ShiCarShippingCarrierId).HasColumnName("ShiCar__ShippingCarrierID");
        entity.Property(e => e.ShiMetShippingMethodId).HasColumnName("ShiMet__ShippingMethodID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VOrderLinesThatNeedPlatesCreated> entity);
}
