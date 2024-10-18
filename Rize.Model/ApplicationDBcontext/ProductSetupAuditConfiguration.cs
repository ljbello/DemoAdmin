using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductSetupAuditConfiguration : IEntityTypeConfiguration<ProductSetupAudit>
{
    public void Configure(EntityTypeBuilder<ProductSetupAudit> entity)
    {
        entity.ToTable("ProductSetupAudit");

        entity.HasIndex(e => e.ProductId, "ProductSetupAudit_IX1");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.ProductId).HasColumnName("ProductID");
        entity.Property(e => e.VersionData).HasColumnType("xml");

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ProductSetupAudits)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductSetupAudit_UserID");

        entity.HasOne(d => d.Product).WithMany(p => p.ProductSetupAudits)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductSetupAudit_tblProducts");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductSetupAudit> entity);
}
