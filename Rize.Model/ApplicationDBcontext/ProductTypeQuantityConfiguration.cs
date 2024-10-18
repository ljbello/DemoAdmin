using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductTypeQuantityConfiguration : IEntityTypeConfiguration<ProductTypeQuantity>
{
    public void Configure(EntityTypeBuilder<ProductTypeQuantity> entity)
    {
        entity.HasKey(e => new { e.VariationId, e.StoreId, e.ProductTypeId }).HasName("PK__ProductT__CC8B91A1A1A9E0FE");

        entity.ToTable("ProductTypeQuantity");

        entity.HasOne(d => d.ProductType).WithMany(p => p.ProductTypeQuantities)
                .HasForeignKey(d => d.ProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTypeQuantity_ProductType");

        entity.HasOne(d => d.Store).WithMany(p => p.ProductTypeQuantities)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTypeQuantity_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductTypeQuantity> entity);
}
