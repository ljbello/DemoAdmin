using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductTypeConfiguration : IEntityTypeConfiguration<ProductType>
{
    public void Configure(EntityTypeBuilder<ProductType> entity)
    {
        entity.ToTable("ProductType");

        entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
        entity.Property(e => e.AllowAop)
                .HasDefaultValue(true)
                .HasColumnName("AllowAOP");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.DefaultProductionTimeId)
                .HasDefaultValue(2)
                .HasColumnName("DefaultProductionTimeID");
        entity.Property(e => e.ProductNumberPrefix)
                .HasMaxLength(2)
                .IsUnicode(false);
        entity.Property(e => e.ProductType1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProductType");
        entity.Property(e => e.ShowStartAtPrice).HasDefaultValue(true);

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ProductTypes)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_ProductType_tblUsers");

        entity.HasOne(d => d.DefaultProductionTime).WithMany(p => p.ProductTypes)
                .HasForeignKey(d => d.DefaultProductionTimeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductType_tblProductionTimes");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductType> entity);
}
