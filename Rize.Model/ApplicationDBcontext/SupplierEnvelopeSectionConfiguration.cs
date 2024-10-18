using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierEnvelopeSectionConfiguration : IEntityTypeConfiguration<SupplierEnvelopeSection>
{
    public void Configure(EntityTypeBuilder<SupplierEnvelopeSection> entity)
    {
        entity.HasKey(e => new { e.SupplierEnvelopeId, e.SectionId });

        entity.ToTable("SupplierEnvelope_Section");

        entity.Property(e => e.SupplierEnvelopeId).HasColumnName("SupplierEnvelopeID");
        entity.Property(e => e.EntityCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.PlateAnchor).HasDefaultValue(1);
        entity.Property(e => e.PreviewGroup)
                .HasMaxLength(30)
                .IsUnicode(false);

        entity.HasOne(d => d.SupplierEnvelope).WithMany(p => p.SupplierEnvelopeSections)
                .HasForeignKey(d => d.SupplierEnvelopeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierEnvelope_Section_tblSupplierEnvelopes");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierEnvelopeSection> entity);
}
