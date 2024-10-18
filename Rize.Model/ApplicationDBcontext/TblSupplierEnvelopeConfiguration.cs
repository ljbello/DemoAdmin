using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblSupplierEnvelopeConfiguration : IEntityTypeConfiguration<TblSupplierEnvelope>
{
    public void Configure(EntityTypeBuilder<TblSupplierEnvelope> entity)
    {
        entity.HasKey(e => e.SupEnvSupplierEnvelopeId).HasName("tblSupplierEnvelopes_PK");

        entity.ToTable("tblSupplierEnvelopes");

        entity.HasIndex(e => new { e.SupEnvSupplierEnvelopeId, e.EnvEnvelopeId, e.SupEnvSupplierEnvelopeCode }, "tblSupplierEnvelopes_IX1");

        entity.HasIndex(e => new { e.SupEnvSupplierEnvelopeId, e.SupSupplierId, e.SupEnvSupplierEnvelopeCode }, "tblSupplierEnvelopes_IX2");

        entity.HasIndex(e => e.IsActive, "tblSupplierEnvelopes_IX3");

        entity.HasIndex(e => new { e.SupEnvSupplierEnvelopeCode, e.SupEnvSupplierEnvelopeId, e.SupSupplierId, e.EnvEnvelopeId }, "tblSuppliers_IX1");

        entity.Property(e => e.SupEnvSupplierEnvelopeId).HasColumnName("SupEnv__SupplierEnvelopeID");
        entity.Property(e => e.AllowAddressing).HasDefaultValue(false);
        entity.Property(e => e.AllowFlapPrinting).HasDefaultValue(true);
        entity.Property(e => e.AllowFrontPrinting).HasDefaultValue(true);
        entity.Property(e => e.AllowMailing).HasDefaultValue(false);
        entity.Property(e => e.CartDisclaimer).HasMaxLength(600);
        entity.Property(e => e.EnvEnvelopeId).HasColumnName("Env__EnvelopeID");
        entity.Property(e => e.InkColorGroupId).HasDefaultValue(2);
        entity.Property(e => e.IsActive).HasDefaultValue(true);
        entity.Property(e => e.ManManufacturerId).HasColumnName("Man__ManufacturerID");
        entity.Property(e => e.SupEnvEnvelopeImage)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SupEnv__EnvelopeImage");
        entity.Property(e => e.SupEnvExtraPostageRequired).HasColumnName("SupEnv__ExtraPostageRequired");
        entity.Property(e => e.SupEnvManufacturerItemNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SupEnv__ManufacturerItemNumber");
        entity.Property(e => e.SupEnvPreviewTemplateName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SupEnv__PreviewTemplateName");
        entity.Property(e => e.SupEnvProductionTemplateName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SupEnv__ProductionTemplateName");
        entity.Property(e => e.SupEnvSortOrder).HasColumnName("SupEnv__SortOrder");
        entity.Property(e => e.SupEnvSupplierEnvelopeCode)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("SupEnv__SupplierEnvelopeCode");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");

        entity.HasOne(d => d.AlternativeEnvelope).WithMany(p => p.InverseAlternativeEnvelope)
                .HasForeignKey(d => d.AlternativeEnvelopeId)
                .HasConstraintName("FK_tblSupplierEnvelopes_AlternativeEnvelopeId");

        entity.HasOne(d => d.EnvEnvelope).WithMany(p => p.TblSupplierEnvelopes)
                .HasForeignKey(d => d.EnvEnvelopeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Envelopes_tblSupplierEnvelopes_FK1");

        entity.HasOne(d => d.ManManufacturer).WithMany(p => p.TblSupplierEnvelopes)
                .HasForeignKey(d => d.ManManufacturerId)
                .HasConstraintName("FK_tblSupplierEnvelopes_tblManufacturers");

        entity.HasOne(d => d.SupSupplier).WithMany(p => p.TblSupplierEnvelopes)
                .HasForeignKey(d => d.SupSupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblSuppliers_tblSupplierEnvelopes_FK1");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblSupplierEnvelope> entity);
}
