using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductTypeWeightConfiguration : IEntityTypeConfiguration<ProductTypeWeight>
{
    public void Configure(EntityTypeBuilder<ProductTypeWeight> entity)
    {
        entity.HasKey(e => new { e.VariationId, e.StoreId, e.ProductTypeId }).HasName("PK__ProductT__CC8B91A14639AF05");

        entity.ToTable("ProductTypeWeight");

        entity.Property(e => e.Weight).HasColumnType("decimal(8, 4)");

        entity.HasOne(d => d.ProductType).WithMany(p => p.ProductTypeWeights)
                .HasForeignKey(d => d.ProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTypeWeight_ProductType");

        entity.HasOne(d => d.Store).WithMany(p => p.ProductTypeWeights)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTypeWeight_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductTypeWeight> entity);
}
