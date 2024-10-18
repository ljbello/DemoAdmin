using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductOptionPriceGroupConfiguration : IEntityTypeConfiguration<ProductOptionPriceGroup>
{
    public void Configure(EntityTypeBuilder<ProductOptionPriceGroup> entity)
    {
        entity.ToTable("ProductOptionPriceGroup");

        entity.HasIndex(e => new { e.StoreId, e.Id, e.ProductOptionPriceGroupId }, "ProductOptionPriceGroup_IX1");

        entity.Property(e => e.CreatedBy).HasDefaultValue(1);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.ProductOptionPriceGroupId)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.StoreId).HasDefaultValue(1);

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ProductOptionPriceGroupCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductOptionPriceGroup_tblUsers_Created");

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.ProductOptionPriceGroupModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_ProductOptionPriceGroup_tblUsers_Modified");

        entity.HasOne(d => d.ProductOptionType).WithMany(p => p.ProductOptionPriceGroups)
                .HasForeignKey(d => d.ProductOptionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductOptionPriceGroup_ProductOptionType");

        entity.HasOne(d => d.Store).WithMany(p => p.ProductOptionPriceGroups)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductOptionPriceGroup_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductOptionPriceGroup> entity);
}
