using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ShippingCostPredictionVariationWeightConfiguration : IEntityTypeConfiguration<ShippingCostPredictionVariationWeight>
{
    public void Configure(EntityTypeBuilder<ShippingCostPredictionVariationWeight> entity)
    {
        entity.HasKey(e => new { e.ProductVariationId, e.PaperStockFinishId });

        entity.ToTable("ShippingCostPrediction_VariationWeights");

        entity.Property(e => e.WeightPerCard).HasColumnType("decimal(15, 5)");

        entity.HasOne(d => d.PaperStockFinish).WithMany(p => p.ShippingCostPredictionVariationWeights)
                .HasForeignKey(d => d.PaperStockFinishId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShippingCostPrediction_VariationWeights_PaperStockFinish");

        entity.HasOne(d => d.ProductVariation).WithMany(p => p.ShippingCostPredictionVariationWeights)
                .HasForeignKey(d => d.ProductVariationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShippingCostPrediction_VariationWeights_ProductVariation");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ShippingCostPredictionVariationWeight> entity);
}
