using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ShippingCostPredictionBoxWeightConfiguration : IEntityTypeConfiguration<ShippingCostPredictionBoxWeight>
{
    public void Configure(EntityTypeBuilder<ShippingCostPredictionBoxWeight> entity)
    {
        entity
                .HasNoKey()
                .ToTable("ShippingCostPrediction_BoxWeights");

        entity.Property(e => e.BoxType)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.WeightPerBox).HasColumnType("decimal(15, 5)");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ShippingCostPredictionBoxWeight> entity);
}
