using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierEnvelopeSectionLayoutConfiguration : IEntityTypeConfiguration<SupplierEnvelopeSectionLayout>
{
    public void Configure(EntityTypeBuilder<SupplierEnvelopeSectionLayout> entity)
    {
        entity.HasKey(e => new { e.SupplierEnvelopeId, e.SectionId, e.LayoutId });

        entity.ToTable("SupplierEnvelope_Section_Layout");

        entity.HasIndex(e => new { e.SupplierEnvelopeId, e.SectionId }, "IX_SupplierEnvelope_Section_Layout");

        entity.Property(e => e.SupplierEnvelopeId).HasColumnName("SupplierEnvelopeID");
        entity.Property(e => e.EntityCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        entity.HasOne(d => d.Layout).WithMany(p => p.SupplierEnvelopeSectionLayouts)
                .HasForeignKey(d => d.LayoutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierEnvelope_Section_Layout_Layout");

        entity.HasOne(d => d.Section).WithMany(p => p.SupplierEnvelopeSectionLayouts)
                .HasForeignKey(d => d.SectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierEnvelope_Section_Layout_Section");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierEnvelopeSectionLayout> entity);
}
