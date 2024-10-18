using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductSetupVariationAuditConfiguration : IEntityTypeConfiguration<ProductSetupVariationAudit>
{
    public void Configure(EntityTypeBuilder<ProductSetupVariationAudit> entity)
    {
        entity.ToTable("ProductSetupVariationAudit");

        entity.HasIndex(e => new { e.StoreId, e.ProductId, e.VariationId }, "ProductSetupVariationAudit_IX1");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.ProductId).HasColumnName("ProductID");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.VariationId).HasColumnName("VariationID");
        entity.Property(e => e.VersionXml)
                .HasColumnType("xml")
                .HasColumnName("VersionXML");

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ProductSetupVariationAudits)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductSetupVariationAudit_tblUsers");

        entity.HasOne(d => d.Variation).WithMany(p => p.ProductSetupVariationAudits)
                .HasForeignKey(d => d.VariationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductSetupVariationAudit_ProductVariation");

        entity.HasOne(d => d.TblStoreProduct).WithMany(p => p.ProductSetupVariationAudits)
                .HasForeignKey(d => new { d.StoreId, d.ProductId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductSetupVariationAudit_tblStoreProducts");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductSetupVariationAudit> entity);
}
