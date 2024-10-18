using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VVariationPricingGroupDefaultConfiguration : IEntityTypeConfiguration<VVariationPricingGroupDefault>
{
    public void Configure(EntityTypeBuilder<VVariationPricingGroupDefault> entity)
    {
        entity
                .HasNoKey()
                .ToView("vVariationPricingGroupDefault");

        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.PricingGroupId).HasColumnName("PricingGroupID");
        entity.Property(e => e.ProductType)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
        entity.Property(e => e.ProductVariation)
                .HasMaxLength(101)
                .IsUnicode(false);
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.VariationId).HasColumnName("VariationID");
        entity.Property(e => e.VariationPricingGroup)
                .HasMaxLength(500)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VVariationPricingGroupDefault> entity);
}
