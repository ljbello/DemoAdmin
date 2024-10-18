using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VariationPriceGroupQuantityConfiguration : IEntityTypeConfiguration<VariationPriceGroupQuantity>
{
    public void Configure(EntityTypeBuilder<VariationPriceGroupQuantity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__Variatio__3214EC27E76BFBFF");

        entity.ToTable("VariationPriceGroupQuantity");

        entity.HasIndex(e => new { e.PriceGroupId, e.LowerQty, e.HigherQty }, "VariationPriceGroupQuantity_IX1");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CostPerPiece).HasColumnType("money");
        entity.Property(e => e.PriceGroupId).HasColumnName("PriceGroupID");

        entity.HasOne(d => d.PriceGroup).WithMany(p => p.VariationPriceGroupQuantities)
                .HasForeignKey(d => d.PriceGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VariationPriceGroupQuantity_VariationPricingGroup");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VariationPriceGroupQuantity> entity);
}
