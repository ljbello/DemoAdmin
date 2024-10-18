using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductOptionPriceGroupDetailConfiguration : IEntityTypeConfiguration<ProductOptionPriceGroupDetail>
{
    public void Configure(EntityTypeBuilder<ProductOptionPriceGroupDetail> entity)
    {
        entity.ToTable("ProductOptionPriceGroupDetail");

        entity.HasIndex(e => new { e.ProductOptionPriceGroupId, e.AdditionalPricePerCard, e.LowerQuantityLimit, e.UpperQuantityLimit }, "ProductOptionPriceGroupDetail_IX1");

        entity.HasIndex(e => new { e.LowerQuantityLimit, e.UpperQuantityLimit }, "ProductOptionPriceGroupDetail_IX2");

        entity.HasIndex(e => new { e.PriceGroupId, e.LowerQuantityLimit, e.UpperQuantityLimit }, "ProductOptionPriceGroupDetail_IX3");

        entity.Property(e => e.AdditionalPricePerCard).HasColumnType("money");
        entity.Property(e => e.EntityCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.EntityDescriptor).HasMaxLength(250);
        entity.Property(e => e.FriendlyDescription).HasMaxLength(150);
        entity.Property(e => e.FriendlyName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ImageName).HasMaxLength(100);
        entity.Property(e => e.PriceGroupId).HasColumnName("PriceGroupID");
        entity.Property(e => e.ProductOptionPriceGroupId)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.SupplierSku)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("SupplierSKU");

        entity.HasOne(d => d.PriceGroup).WithMany(p => p.ProductOptionPriceGroupDetails)
                .HasForeignKey(d => d.PriceGroupId)
                .HasConstraintName("FK_ProductOptionPriceGroupDetail_ProductOptionPriceGroup");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductOptionPriceGroupDetail> entity);
}
