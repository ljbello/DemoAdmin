using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class StoreProductTypeConfiguration : IEntityTypeConfiguration<StoreProductType>
{
    public void Configure(EntityTypeBuilder<StoreProductType> entity)
    {
        entity.ToTable("StoreProductType");

        entity.HasIndex(e => new { e.StoreId, e.ProductTypeId }, "CK_StoreProductType_StoreIdProductTypeId").IsUnique();

        entity.HasOne(d => d.ProductType).WithMany(p => p.StoreProductTypes)
                .HasForeignKey(d => d.ProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StoreProductType_ProductType");

        entity.HasOne(d => d.Store).WithMany(p => p.StoreProductTypes)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StoreProductType_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<StoreProductType> entity);
}
