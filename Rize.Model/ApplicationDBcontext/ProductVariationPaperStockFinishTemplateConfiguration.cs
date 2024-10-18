using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductVariationPaperStockFinishTemplateConfiguration : IEntityTypeConfiguration<ProductVariationPaperStockFinishTemplate>
{
    public void Configure(EntityTypeBuilder<ProductVariationPaperStockFinishTemplate> entity)
    {
        entity.HasKey(e => new { e.ProductVariationId, e.StoreId, e.PaperStockFinishId });

        entity.ToTable("ProductVariation_PaperStockFinish_Template");

        entity.Property(e => e.StoreId)
                .HasDefaultValue(1)
                .HasColumnName("StoreID");

        entity.HasOne(d => d.PaperStockFinish).WithMany(p => p.ProductVariationPaperStockFinishTemplates)
                .HasForeignKey(d => d.PaperStockFinishId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductVariation_PaperStockFinish_PaperStockFinish_Template_Template");

        entity.HasOne(d => d.ProductVariation).WithMany(p => p.ProductVariationPaperStockFinishTemplates)
                .HasForeignKey(d => d.ProductVariationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductVariation_PaperStockFinish_ProductVariation_PaperStockFinish_Template");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductVariationPaperStockFinishTemplate> entity);
}
