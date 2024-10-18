using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ViewProductAvailableEnvelopeConfiguration : IEntityTypeConfiguration<ViewProductAvailableEnvelope>
{
    public void Configure(EntityTypeBuilder<ViewProductAvailableEnvelope> entity)
    {
        entity
                .HasNoKey()
                .ToView("viewProductAvailableEnvelope");

        entity.Property(e => e.AlternateEnvelopeCode)
                .HasMaxLength(16)
                .IsUnicode(false);
        entity.Property(e => e.AlternateEnvelopeDescription)
                .HasMaxLength(48)
                .IsUnicode(false);
        entity.Property(e => e.AlternateEnvelopeId).HasColumnName("AlternateEnvelopeID");
        entity.Property(e => e.AlternateEnvelopeSupplierId).HasColumnName("AlternateEnvelopeSupplierID");
        entity.Property(e => e.AlternateEnvelopeTypeId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AlternateEnvelopeTypeID");
        entity.Property(e => e.AlternateSupplierEnvelopeDescription).HasMaxLength(600);
        entity.Property(e => e.AlternateSupplierEnvelopeId).HasColumnName("AlternateSupplierEnvelopeID");
        entity.Property(e => e.EnvelopeDescription)
                .HasMaxLength(48)
                .IsUnicode(false);
        entity.Property(e => e.EnvelopeId).HasColumnName("EnvelopeID");
        entity.Property(e => e.EnvelopeImage)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.EnvelopeTypeDescription)
                .HasMaxLength(64)
                .IsUnicode(false);
        entity.Property(e => e.EnvelopeTypeId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EnvelopeTypeID");
        entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");
        entity.Property(e => e.ManufacturerItemNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ProductId).HasColumnName("ProductID");
        entity.Property(e => e.ProductVariationId).HasColumnName("ProductVariationID");
        entity.Property(e => e.SupEnvPreviewTemplateName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SupEnv__PreviewTemplateName");
        entity.Property(e => e.SupEnvProductionTemplateName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SupEnv__ProductionTemplateName");
        entity.Property(e => e.SupplierEnvelopeCode)
                .HasMaxLength(16)
                .IsUnicode(false);
        entity.Property(e => e.SupplierEnvelopeDescription).HasMaxLength(600);
        entity.Property(e => e.SupplierEnvelopeId).HasColumnName("SupplierEnvelopeID");
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ViewProductAvailableEnvelope> entity);
}
