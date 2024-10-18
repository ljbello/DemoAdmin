using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrdersAuditConfiguration : IEntityTypeConfiguration<TblOrdersAudit>
{
    public void Configure(EntityTypeBuilder<TblOrdersAudit> entity)
    {
        entity.ToTable("tblOrdersAudit");

        entity.Property(e => e.TblOrdersAuditId).HasColumnName("tblOrdersAuditID");
        entity.Property(e => e.BasBasketId).HasColumnName("Bas__BasketID");
        entity.Property(e => e.CanadaShipping).HasColumnType("money");
        entity.Property(e => e.CanadianDutiesAndTaxes).HasColumnType("money");
        entity.Property(e => e.CanadianEntryPreparationFee).HasColumnType("money");
        entity.Property(e => e.CityTax).HasColumnType("money");
        entity.Property(e => e.CityTaxRate).HasColumnType("money");
        entity.Property(e => e.CountyTax).HasColumnType("money");
        entity.Property(e => e.CountyTaxRate).HasColumnType("money");
        entity.Property(e => e.CusCatReqCustomerCatalogRequestId).HasColumnName("CusCatReq__CustomerCatalogRequestID");
        entity.Property(e => e.CusCustomerId).HasColumnName("Cus__CustomerID");
        entity.Property(e => e.DelaySubmitDate).HasColumnType("datetime");
        entity.Property(e => e.DistrictTax).HasColumnType("money");
        entity.Property(e => e.DistrictTaxRate).HasColumnType("money");
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
        entity.Property(e => e.OrdInvoiceDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ord__InvoiceDate");
        entity.Property(e => e.OrdInvoiceNumber)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Ord__InvoiceNumber");
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
        entity.Property(e => e.RegisterTaxDate).HasColumnType("datetime");
        entity.Property(e => e.RegisteredTaxOrderAmount).HasColumnType("money");
        entity.Property(e => e.RegisteredTaxShippingAmount).HasColumnType("money");
        entity.Property(e => e.RegisteredTaxTotal).HasColumnType("money");
        entity.Property(e => e.SettlementAmount).HasColumnType("money");
        entity.Property(e => e.StateTax).HasColumnType("money");
        entity.Property(e => e.StateTaxRate).HasColumnType("money");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.TaxingStateId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TaxingStateID");
        entity.Property(e => e.TblOrdersAuditTs)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("tblOrdersAudit_TS");
        entity.Property(e => e.TotalTaxRate).HasColumnType("money");
        entity.Property(e => e.UpdateDate).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrdersAudit> entity);
}
