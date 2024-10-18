using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class BaseVariationOptionSidesPricingConfiguration : IEntityTypeConfiguration<BaseVariationOptionSidesPricing>
{
    public void Configure(EntityTypeBuilder<BaseVariationOptionSidesPricing> entity)
    {
        entity
                .HasNoKey()
                .ToView("BaseVariationOptionSidesPricing");

        entity.Property(e => e.AdditionalPricePerCard).HasColumnType("money");
        entity.Property(e => e.EntityDescriptor).HasMaxLength(250);
        entity.Property(e => e.FriendlyName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.PriceGroupId).HasColumnName("PriceGroupID");
        entity.Property(e => e.ProductOptionPriceGroupId)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<BaseVariationOptionSidesPricing> entity);
}
