using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierEmailExtractorConfiguration : IEntityTypeConfiguration<SupplierEmailExtractor>
{
    public void Configure(EntityTypeBuilder<SupplierEmailExtractor> entity)
    {
        entity.ToTable("SupplierEmailExtractor");

        entity.HasIndex(e => new { e.SupplierId, e.InvoiceFile }, "IX_SupplierEmailExtractor").IsUnique();

        entity.Property(e => e.SupplierEmailExtractorId).HasColumnName("SupplierEmailExtractorID");
        entity.Property(e => e.EmailPath)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.FilterValue)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

        entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierEmailExtractors)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierEmailExtractor_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierEmailExtractor> entity);
}
