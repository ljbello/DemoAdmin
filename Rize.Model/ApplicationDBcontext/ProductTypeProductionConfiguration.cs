using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductTypeProductionConfiguration : IEntityTypeConfiguration<ProductTypeProduction>
{
    public void Configure(EntityTypeBuilder<ProductTypeProduction> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__ProductT__3214EC07D37D653C");

        entity.ToTable("ProductTypeProduction");

        entity.HasOne(d => d.ProductType).WithMany(p => p.ProductTypeProductions)
                .HasForeignKey(d => d.ProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTypeProduction_ProductType");

        entity.HasOne(d => d.ProductionType).WithMany(p => p.ProductTypeProductions)
                .HasForeignKey(d => d.ProductionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTypeProduction_ProductionType");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductTypeProduction> entity);
}
