using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ReportGetOrderlineCostPredictionViewConfiguration : IEntityTypeConfiguration<ReportGetOrderlineCostPredictionView>
{
    public void Configure(EntityTypeBuilder<ReportGetOrderlineCostPredictionView> entity)
    {
        entity
                .HasNoKey()
                .ToView("ReportGetOrderlineCostPredictionView");

        entity.Property(e => e.ActualCardCost).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.ActualCardFoilCharge).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.ActualCardSupplierPartId)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ActualCardUnitPrice).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.ActualEnvelopeCost).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.ActualEnvelopeFoilCharge).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.ActualEnvelopeSupplierPartId)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ActualEnvelopeUnitPrice).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.ActualInvoiceCreditsAndDebits).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.ActualInvoiceShipping).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.ActualInvoiceSubTotals).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.ActualPmsinkCharge)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("ActualPMSInkCharge");
        entity.Property(e => e.ActualRegistrationCharge).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.ActualTotalPossiblyInvalid).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.ActualTwoColorCharge).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.AmountDollarDiffByQty).HasColumnType("decimal(28, 13)");
        entity.Property(e => e.DiffCardCost).HasColumnType("decimal(17, 2)");
        entity.Property(e => e.DiffCardFoilCharge).HasColumnType("decimal(17, 2)");
        entity.Property(e => e.DiffEnvelopeCost).HasColumnType("decimal(17, 2)");
        entity.Property(e => e.DiffEnvelopeFoilCharge).HasColumnType("decimal(17, 2)");
        entity.Property(e => e.DiffPercentCardCost).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.DiffPercentCardFoilCharge).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.DiffPercentEnvelopeCost).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.DiffPercentEnvelopeFoilCharge).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.DiffPercentPmscharge)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("DiffPercentPMSCharge");
        entity.Property(e => e.DiffPercentRegistrationCharge).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.DiffPercentTotal).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.DiffPercentTwoColorCharge).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.DiffPmscharge)
                .HasColumnType("decimal(17, 2)")
                .HasColumnName("DiffPMSCharge");
        entity.Property(e => e.DiffRegistrationCharge).HasColumnType("decimal(17, 2)");
        entity.Property(e => e.DiffTotal).HasColumnType("decimal(17, 2)");
        entity.Property(e => e.DiffTwoColorCharge).HasColumnType("decimal(17, 2)");
        entity.Property(e => e.DisplayName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ExpectedCardCost).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.ExpectedCardFoilCharge).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.ExpectedEnvelopeCost).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.ExpectedEnvelopeFoilCharge).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.ExpectedPmsinkCharge)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("ExpectedPMSInkCharge");
        entity.Property(e => e.ExpectedRegistrationCharge).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.ExpectedTotal).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.ExpectedTwoColorCharge).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.FriendlyName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Notes)
                .HasMaxLength(1)
                .IsUnicode(false);
        entity.Property(e => e.OrdAdditionalDiscountTotal)
                .HasColumnType("money")
                .HasColumnName("Ord__AdditionalDiscountTotal");
        entity.Property(e => e.OrderAdjustments).HasColumnType("money");
        entity.Property(e => e.OrderId).HasColumnName("OrderID");
        entity.Property(e => e.OrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.OrderTotal).HasColumnType("money");
        entity.Property(e => e.ProcessingStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.ProductNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ProfitDollar)
                .HasMaxLength(1)
                .IsUnicode(false);
        entity.Property(e => e.ProfitPercent)
                .HasMaxLength(1)
                .IsUnicode(false);
        entity.Property(e => e.Pv3envelopeText).HasColumnName("PV3EnvelopeText");
        entity.Property(e => e.SupplierProductNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.TotalInvoice).HasColumnType("decimal(18, 2)");
        entity.Property(e => e.TotalSettlementAmount).HasColumnType("money");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ReportGetOrderlineCostPredictionView> entity);
}
