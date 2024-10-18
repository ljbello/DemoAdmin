using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductConstructorCodeConfiguration : IEntityTypeConfiguration<ProductConstructorCode>
{
    public void Configure(EntityTypeBuilder<ProductConstructorCode> entity)
    {
        entity.HasIndex(e => new { e.VariationId, e.ProductType, e.PaperStockFinishId }, "ProductConstructorCodes_IX1");

        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.InternalNotes).HasMaxLength(1024);
        entity.Property(e => e.ModifiedBy).HasDefaultValue(1);
        entity.Property(e => e.ModifiedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.PointConstructorCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ProductionConstructorCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.StockCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        entity.Property(e => e.VarOption)
                .HasMaxLength(10)
                .IsUnicode(false);

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.ProductConstructorCodes)
                .HasForeignKey(d => d.ModifiedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductConstructorCodes_tblUsers");

        entity.HasOne(d => d.ProductTypeNavigation).WithMany(p => p.ProductConstructorCodes)
                .HasForeignKey(d => d.ProductType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductConstructorCodes_ProductType");

        entity.HasOne(d => d.Store).WithMany(p => p.ProductConstructorCodes)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductConstructorCodes_tblStores");

        entity.HasOne(d => d.Variation).WithMany(p => p.ProductConstructorCodes)
                .HasForeignKey(d => d.VariationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductConstructorCodes_ProductVariation");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductConstructorCode> entity);
}
