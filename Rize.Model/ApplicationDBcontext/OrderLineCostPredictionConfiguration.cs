using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderLineCostPredictionConfiguration : IEntityTypeConfiguration<OrderLineCostPrediction>
{
    public void Configure(EntityTypeBuilder<OrderLineCostPrediction> entity)
    {
        entity.HasKey(e => e.OrderLineId);

        entity.ToTable("OrderLineCostPrediction");

        entity.Property(e => e.OrderLineId).ValueGeneratedNever();
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
        entity.Property(e => e.OrderId).HasColumnName("OrderID");
        entity.Property(e => e.OrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ProcessingStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.ProductNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.SupplierProductNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderLineCostPrediction> entity);
}
