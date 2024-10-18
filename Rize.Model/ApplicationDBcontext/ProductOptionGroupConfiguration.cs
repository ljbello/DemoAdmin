using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductOptionGroupConfiguration : IEntityTypeConfiguration<ProductOptionGroup>
{
    public void Configure(EntityTypeBuilder<ProductOptionGroup> entity)
    {
        entity.ToTable("Product_OptionGroup");

        entity.HasIndex(e => new { e.StoreId, e.ProductId, e.VariationId }, "IX_Product_OptionGroup_StoreId_ProductId").IsUnique();

        entity.Property(e => e.Active).HasDefaultValue(true);
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.FriendlyName)
                .HasMaxLength(50)
                .IsUnicode(false);

        entity.HasOne(d => d.PriceGroup).WithMany(p => p.ProductOptionGroups)
                .HasForeignKey(d => d.PriceGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_OptionGroup_ProductOptionPriceGroup");

        entity.HasOne(d => d.Product).WithMany(p => p.ProductOptionGroups)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_OptionGroup_tblProducts");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductOptionGroup> entity);
}
