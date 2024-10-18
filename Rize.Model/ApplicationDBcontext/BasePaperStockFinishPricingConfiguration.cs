using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class BasePaperStockFinishPricingConfiguration : IEntityTypeConfiguration<BasePaperStockFinishPricing>
{
    public void Configure(EntityTypeBuilder<BasePaperStockFinishPricing> entity)
    {
        entity
                .HasNoKey()
                .ToView("BasePaperStockFinishPricing");

        entity.Property(e => e.AdditionalPricePerCard).HasColumnType("money");
        entity.Property(e => e.DisplayName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.InternalName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ProductOptionPriceGroupId)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.StoreId).HasColumnName("StoreID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<BasePaperStockFinishPricing> entity);
}
