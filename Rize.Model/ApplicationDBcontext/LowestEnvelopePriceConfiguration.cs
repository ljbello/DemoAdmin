using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class LowestEnvelopePriceConfiguration : IEntityTypeConfiguration<LowestEnvelopePrice>
{
    public void Configure(EntityTypeBuilder<LowestEnvelopePrice> entity)
    {
        entity.HasKey(e => new { e.ProductId, e.StoreId });

        entity.ToTable("LowestEnvelopePrice");

        entity.Property(e => e.ProductId).HasColumnName("ProductID");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.EnvelopeCost).HasColumnType("numeric(24, 8)");
        entity.Property(e => e.InsertDate).HasColumnType("datetime");
        entity.Property(e => e.UpdateDate).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<LowestEnvelopePrice> entity);
}
