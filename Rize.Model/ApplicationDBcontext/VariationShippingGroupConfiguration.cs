using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VariationShippingGroupConfiguration : IEntityTypeConfiguration<VariationShippingGroup>
{
    public void Configure(EntityTypeBuilder<VariationShippingGroup> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__Variatio__3214EC07BFF4C711");

        entity.ToTable("VariationShippingGroup");

        entity.HasIndex(e => new { e.StoreId, e.VariationId, e.CreatedOn }, "VariationShippingGroup_IX1");

        entity.Property(e => e.Active).HasDefaultValue(true);
        entity.Property(e => e.CreatedBy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.UseGlobalRate).HasDefaultValue(true);

        entity.HasOne(d => d.ShippingGroup).WithMany(p => p.VariationShippingGroups)
                .HasForeignKey(d => d.ShippingGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VariationShippingGroup_ShippingGroup");

        entity.HasOne(d => d.Variation).WithMany(p => p.VariationShippingGroups)
                .HasForeignKey(d => d.VariationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VariationShippingGroup_ProductVariation");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VariationShippingGroup> entity);
}
