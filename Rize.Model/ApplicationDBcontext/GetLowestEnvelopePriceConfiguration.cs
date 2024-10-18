using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class GetLowestEnvelopePriceConfiguration : IEntityTypeConfiguration<GetLowestEnvelopePrice>
{
    public void Configure(EntityTypeBuilder<GetLowestEnvelopePrice> entity)
    {
        entity
                .HasNoKey()
                .ToView("GetLowestEnvelopePrice");

        entity.Property(e => e.EnvelopeCost).HasColumnType("numeric(24, 8)");
        entity.Property(e => e.ProductId).HasColumnName("ProductID");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<GetLowestEnvelopePrice> entity);
}
