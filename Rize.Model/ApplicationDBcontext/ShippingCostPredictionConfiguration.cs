using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ShippingCostPredictionConfiguration : IEntityTypeConfiguration<ShippingCostPrediction>
{
    public void Configure(EntityTypeBuilder<ShippingCostPrediction> entity)
    {
        entity.HasKey(e => e.OrderPartId);

        entity.ToTable("ShippingCostPrediction");

        entity.Property(e => e.OrderPartId).ValueGeneratedNever();
        entity.Property(e => e.CalculatedWeight).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.OrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ShipFromZip)
                .HasMaxLength(10)
                .IsUnicode(false);
        entity.Property(e => e.ShipToZip)
                .HasMaxLength(10)
                .IsUnicode(false);
        entity.Property(e => e.ShippingCost).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.ShippingRequestErrorMessage).HasColumnType("text");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ShippingCostPrediction> entity);
}
