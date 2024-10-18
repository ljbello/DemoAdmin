using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductPaperStockFinishConfiguration : IEntityTypeConfiguration<ProductPaperStockFinish>
{
    public void Configure(EntityTypeBuilder<ProductPaperStockFinish> entity)
    {
        entity.HasKey(e => new { e.ProductId, e.ProductVariationId, e.PaperStockFinishId, e.StoreId });

        entity.ToTable("Product_PaperStockFinish");

        entity.HasIndex(e => new { e.ProductId, e.ProductVariationId }, "IX_Product_PaperStockFinish");

        entity.HasIndex(e => e.PaperStockFinishId, "Product_PaperStockFinish_IX1");

        entity.Property(e => e.StoreId).HasDefaultValue(1);
        entity.Property(e => e.IsActive).HasDefaultValue(true);

        entity.HasOne(d => d.PaperStockFinish).WithMany(p => p.ProductPaperStockFinishes)
                .HasForeignKey(d => d.PaperStockFinishId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_PaperStockFinish_PaperStockFinish");

        entity.HasOne(d => d.Product).WithMany(p => p.ProductPaperStockFinishes)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_PaperStockFinish_tblProducts");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductPaperStockFinish> entity);
}
