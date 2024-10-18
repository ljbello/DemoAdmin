using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderLineConfiguration : IEntityTypeConfiguration<TblOrderLine>
{
    public void Configure(EntityTypeBuilder<TblOrderLine> entity)
    {
        entity.HasKey(e => e.OrdLinOrderLineId).HasName("tblOrderLines_PK");

        entity.ToTable("tblOrderLines", tb =>
                {
                    tb.HasTrigger("StatusChange");
                    tb.HasTrigger("tr_OrderLines_InsertToOrder");
                    tb.HasTrigger("tr_OrderLines_OrderLastUpdatedDate");
                    tb.HasTrigger("tr_OrderLines_Submitted_Update");
                });

        entity.HasIndex(e => e.ReprintFromOrderLineId, "IX_tblOrderLines_ReprintFromOrderLineId");

        entity.HasIndex(e => new { e.OrdLinOrderLineId, e.OrdStaOrderStatusId, e.ParOrderPartId }, "_dta_index_tblOrderLines_7_258868039__K1_K17_K2_4_60").HasFillFactor(95);

        entity.HasIndex(e => new { e.ParOrderPartId, e.OrdStaOrderStatusId, e.OrdLinOrderLineId }, "_dta_index_tblOrderLines_7_258868039__K2_K17_K1_4_60").HasFillFactor(95);

        entity.HasIndex(e => new { e.OrdStaOrderStatusId, e.ParOrderPartId, e.OrdLinShipDate, e.OrdLinSubtotalDollarAmount }, "index_122");

        entity.HasIndex(e => new { e.OrdLinFollowUpWithSupplier, e.OrdStaOrderStatusId }, "index_14");

        entity.HasIndex(e => e.OrdLinPreviewVersion, "index_201");

        entity.HasIndex(e => new { e.OrdStaOrderStatusId, e.OrdLinArtworkCompleted }, "index_74");

        entity.HasIndex(e => e.OrdLinDateSubmitted, "tblOrderLinesIX14");

        entity.HasIndex(e => new { e.ProProductId, e.OrdStaOrderStatusId, e.OrdLinShipDate }, "tblOrderLines_IX1");

        entity.HasIndex(e => new { e.ParOrderPartId, e.IsEnvelopeAddressing, e.IsMailing, e.IsStamping }, "tblOrderLines_IX10");

        entity.HasIndex(e => new { e.OrdStaOrderStatusId, e.UpdateDate }, "tblOrderLines_IX11");

        entity.HasIndex(e => e.ArtworkStatusId, "tblOrderLines_IX12");

        entity.HasIndex(e => new { e.StoreId, e.SupplierEnvelopeId }, "tblOrderLines_IX15");

        entity.HasIndex(e => e.OrdLinShipDate, "tblOrderLines_IX16");

        entity.HasIndex(e => new { e.OrdLinOrderLineId, e.ParOrderPartId, e.OrdLinQuantity, e.OrdLinSubtotalDollarAmount, e.OrdLinDateSubmitted, e.OrdStaOrderStatusId, e.OrdLinShipDate, e.EnvelopeQuantity, e.OrderId }, "tblOrderLines_IX17");

        entity.HasIndex(e => new { e.ParOrderPartId, e.OrdLinOrderLineId, e.ProProductId }, "tblOrderLines_IX2");

        entity.HasIndex(e => new { e.ParOrderPartId, e.OrdStaOrderStatusId, e.ProProductId }, "tblOrderLines_IX3");

        entity.HasIndex(e => e.IsForBusiness, "tblOrderLines_IX4");

        entity.HasIndex(e => new { e.ProProductId, e.OrdStaOrderStatusId, e.OrderStatusChangeDate }, "tblOrderLines_IX6");

        entity.HasIndex(e => e.PlateThumbnailId, "tblOrderLines_IX7");

        entity.HasIndex(e => new { e.ParOrderPartId, e.ProProductId }, "tblOrderLines_IX8");

        entity.HasIndex(e => new { e.OrdStaOrderStatusId, e.OrdLinShipDate }, "tblOrderLines_IX9");

        entity.HasIndex(e => new { e.OrderId, e.OrdStaOrderStatusId }, "tblOrderlines_IX13");

        entity.Property(e => e.OrdLinOrderLineId).HasColumnName("OrdLin__OrderLineID");
        entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.DiscountShippingId).HasDefaultValueSql("(NULL)");
        entity.Property(e => e.EnvelopeInternationalStampingAmount).HasColumnType("money");
        entity.Property(e => e.EnvelopeMailingAmount).HasColumnType("money");
        entity.Property(e => e.EnvelopePersonalizationCost).HasColumnType("money");
        entity.Property(e => e.EnvelopeUsstampingAmount)
                .HasColumnType("money")
                .HasColumnName("EnvelopeUSStampingAmount");
        entity.Property(e => e.EnvelopeUsstampingQty).HasColumnName("EnvelopeUSStampingQty");
        entity.Property(e => e.EstimatedShipDate).HasColumnType("datetime");
        entity.Property(e => e.ExtraEnvelopeAmount).HasColumnType("money");
        entity.Property(e => e.HorizontalOffset).HasColumnType("decimal(9, 3)");
        entity.Property(e => e.HorizontalOffsetEnv).HasColumnType("decimal(9, 3)");
        entity.Property(e => e.IsEnvelopeAddressing).HasDefaultValue(false);
        entity.Property(e => e.IsMailing).HasDefaultValue(false);
        entity.Property(e => e.IsStamping).HasDefaultValue(false);
        entity.Property(e => e.LogoFileName)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.LogoFileName2)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.LogoFileNameEnv)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.OrdLinArtworkCompleted).HasColumnName("OrdLin__ArtworkCompleted");
        entity.Property(e => e.OrdLinChangedBy)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("OrdLin__ChangedBy");
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
        entity.Property(e => e.OrdStaOrderStatusId).HasColumnName("OrdSta__OrderStatusID");
        entity.Property(e => e.OrderId).HasColumnName("OrderID");
        entity.Property(e => e.OrderStatusChangeDate).HasColumnType("datetime");
        entity.Property(e => e.ParOrderPartId).HasColumnName("Par__OrderPartID");
        entity.Property(e => e.PriGroPricingGroupId).HasColumnName("PriGro__PricingGroupID");
        entity.Property(e => e.ProPrice)
                .HasColumnType("money")
                .HasColumnName("Pro__Price");
        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductID");
        entity.Property(e => e.QuantityDollarAmount).HasColumnType("money");
        entity.Property(e => e.ReOrderFromOrderlineId).HasColumnName("ReOrderFromOrderlineID");
        entity.Property(e => e.RepReaReprintReasonId).HasColumnName("RepRea__ReprintReasonID");
        entity.Property(e => e.RequestedMailDate).HasColumnType("datetime");
        entity.Property(e => e.Scale).HasColumnType("decimal(9, 3)");
        entity.Property(e => e.ScaleEnv).HasColumnType("decimal(9, 3)");
        entity.Property(e => e.ShiCarShippingCarrierId).HasColumnName("ShiCar__ShippingCarrierID");
        entity.Property(e => e.ShiMetShippingMethodId).HasColumnName("ShiMet__ShippingMethodID");
        entity.Property(e => e.StatusDelinquencyEmailSentDate).HasColumnType("datetime");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.SupPriPricingGroupId).HasColumnName("SupPri__PricingGroupID");
        entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        entity.Property(e => e.UpgradeFoilCost).HasColumnType("money");
        entity.Property(e => e.UpgradeFullColorCost).HasColumnType("money");
        entity.Property(e => e.UpsdeliveredDate)
                .HasColumnType("datetime")
                .HasColumnName("UPSDeliveredDate");
        entity.Property(e => e.UpsscheduleDeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("UPSScheduleDeliveryDate");
        entity.Property(e => e.UpstrackingLastRequestDate)
                .HasColumnType("datetime")
                .HasColumnName("UPSTrackingLastRequestDate");
        entity.Property(e => e.VariationPricingGroupId).HasColumnName("VariationPricingGroupID");
        entity.Property(e => e.VerseNumber)
                .HasMaxLength(24)
                .IsUnicode(false);
        entity.Property(e => e.VerticalOffset).HasColumnType("decimal(9, 3)");
        entity.Property(e => e.VerticalOffsetEnv).HasColumnType("decimal(9, 3)");

        entity.HasOne(d => d.ArtworkStatus).WithMany(p => p.TblOrderLines)
                .HasForeignKey(d => d.ArtworkStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblOrderLines_ArtworkStatus");

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblOrderLineCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblOrderLines_CreatedUsers");

        entity.HasOne(d => d.DiscountShipping).WithMany(p => p.TblOrderLines)
                .HasForeignKey(d => d.DiscountShippingId)
                .HasConstraintName("FK_tblOrderLines_DiscountShipping");

        entity.HasOne(d => d.InkColor).WithMany(p => p.TblOrderLines)
                .HasForeignKey(d => d.InkColorId)
                .HasConstraintName("FK_tblOrderLines_tblInkColors");

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblOrderLineModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_tblOrderLines_ModifiedUsers");

        entity.HasOne(d => d.OrdLinCompanyEmployeeIdArtworkAssignedNavigation).WithMany(p => p.TblOrderLines)
                .HasForeignKey(d => d.OrdLinCompanyEmployeeIdArtworkAssigned)
                .HasConstraintName("FK_tblOrderLines_tblCompanyEmployees");

        entity.HasOne(d => d.OrdLinReferenceProduct).WithMany(p => p.TblOrderLineOrdLinReferenceProducts)
                .HasForeignKey(d => d.OrdLinReferenceProductId)
                .HasConstraintName("tblOrderLines_tblProducts_FK2");

        entity.HasOne(d => d.OrdStaOrderStatus).WithMany(p => p.TblOrderLines)
                .HasForeignKey(d => d.OrdStaOrderStatusId)
                .HasConstraintName("FK_tblOrderLines_tblOrderStatuses");

        entity.HasOne(d => d.ParOrderPart).WithMany(p => p.TblOrderLines)
                .HasForeignKey(d => d.ParOrderPartId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblOrderLines_tblOrderParts");

        entity.HasOne(d => d.ProProduct).WithMany(p => p.TblOrderLineProProducts)
                .HasForeignKey(d => d.ProProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblOrderLines_tblProducts_FK1");

        entity.HasOne(d => d.RepReaReprintReason).WithMany(p => p.TblOrderLines)
                .HasForeignKey(d => d.RepReaReprintReasonId)
                .HasConstraintName("FK_tblOrderLines_tblReprintReasons");

        entity.HasOne(d => d.ShiCarShippingCarrier).WithMany(p => p.TblOrderLines)
                .HasForeignKey(d => d.ShiCarShippingCarrierId)
                .HasConstraintName("FK_tblOrderLines_tblShippingCarriers");

        entity.HasOne(d => d.ShiMetShippingMethod).WithMany(p => p.TblOrderLines)
                .HasForeignKey(d => d.ShiMetShippingMethodId)
                .HasConstraintName("FK_tblOrderLines_tblShippingMethods");

        entity.HasOne(d => d.SupplierEnvelope).WithMany(p => p.TblOrderLines)
                .HasForeignKey(d => d.SupplierEnvelopeId)
                .HasConstraintName("FK_tblOrderLines_tblSupplierEnvelopes");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderLine> entity);
}
