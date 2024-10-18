using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ShippingCostPredictionWeightAuditConfiguration : IEntityTypeConfiguration<ShippingCostPredictionWeightAudit>
{
    public void Configure(EntityTypeBuilder<ShippingCostPredictionWeightAudit> entity)
    {
        entity.HasKey(e => new { e.OrderId, e.OrderPartId, e.OrderLineId, e.Type });

        entity.ToTable("ShippingCostPrediction_WeightAudit");

        entity.HasIndex(e => e.OrderPartId, "ShippingCostPrediction_WeightAudit_IX1");

        entity.HasIndex(e => e.Weight, "ShippingCostPrediction_WeightAudit_IX2");

        entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false);
        entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Weight).HasColumnType("decimal(16, 2)");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ShippingCostPredictionWeightAudit> entity);
}
