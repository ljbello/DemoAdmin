using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VProductAlternateEnvelopeConfiguration : IEntityTypeConfiguration<VProductAlternateEnvelope>
{
    public void Configure(EntityTypeBuilder<VProductAlternateEnvelope> entity)
    {
        entity
                .HasNoKey()
                .ToView("vProduct_AlternateEnvelopes");

        entity.Property(e => e.AltEnvAlternateSupplierEnvelopeId).HasColumnName("AltEnv__AlternateSupplierEnvelopeId");
        entity.Property(e => e.AltEnvNotes)
                .HasMaxLength(255)
                .HasColumnName("AltEnv__Notes");
        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductId");
        entity.Property(e => e.SupEnvSupplierEnvelopeId).HasColumnName("SupEnv__SupplierEnvelopeId");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VProductAlternateEnvelope> entity);
}
