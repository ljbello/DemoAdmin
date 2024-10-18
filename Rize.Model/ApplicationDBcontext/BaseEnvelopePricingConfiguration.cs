using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class BaseEnvelopePricingConfiguration : IEntityTypeConfiguration<BaseEnvelopePricing>
{
    public void Configure(EntityTypeBuilder<BaseEnvelopePricing> entity)
    {
        entity
                .HasNoKey()
                .ToView("BaseEnvelopePricing");

        entity.Property(e => e.AdditionalCost).HasColumnType("money");
        entity.Property(e => e.Description)
                .HasMaxLength(48)
                .IsUnicode(false);
        entity.Property(e => e.EnvelopeTypeId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
        entity.Property(e => e.ProductOptionPriceGroupId)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.SupplierEnvelopeAmount).HasColumnType("money");
        entity.Property(e => e.SupplierEnvelopeCode)
                .HasMaxLength(16)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<BaseEnvelopePricing> entity);
}
