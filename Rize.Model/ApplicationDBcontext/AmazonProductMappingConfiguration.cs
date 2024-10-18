using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AmazonProductMappingConfiguration : IEntityTypeConfiguration<AmazonProductMapping>
{
    public void Configure(EntityTypeBuilder<AmazonProductMapping> entity)
    {
        entity.HasKey(e => e.AmazonSku).HasName("PK__AmazonPr__4BBC9CFE0E1D7F21");

        entity.ToTable("AmazonProductMapping");

        entity.Property(e => e.AmazonSku)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.AmazonProductMappings)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AmazonProductMapping_tblUsers");

        entity.HasOne(d => d.PaperStockFinish).WithMany(p => p.AmazonProductMappings)
                .HasForeignKey(d => d.PaperStockFinishId)
                .HasConstraintName("FK_AmazonProductMapping_PaperStockFinish");

        entity.HasOne(d => d.Product).WithMany(p => p.AmazonProductMappings)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AmazonProductMapping_tblProducts");

        entity.HasOne(d => d.SupplierEnvelope).WithMany(p => p.AmazonProductMappings)
                .HasForeignKey(d => d.SupplierEnvelopeId)
                .HasConstraintName("FK_AmazonProductMapping_tblSupplierEnvelopes");

        entity.HasOne(d => d.Variation).WithMany(p => p.AmazonProductMappings)
                .HasForeignKey(d => d.VariationId)
                .HasConstraintName("FK_AmazonProductMapping_ProductVariation");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AmazonProductMapping> entity);
}
