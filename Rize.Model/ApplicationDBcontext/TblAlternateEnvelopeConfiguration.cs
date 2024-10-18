using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblAlternateEnvelopeConfiguration : IEntityTypeConfiguration<TblAlternateEnvelope>
{
    public void Configure(EntityTypeBuilder<TblAlternateEnvelope> entity)
    {
        entity.HasKey(e => new { e.SupEnvSupplierEnvelopeId, e.AltEnvAlternateSupplierEnvelopeId }).HasName("tblAlternateEnvelopes_PK");

        entity.ToTable("tblAlternateEnvelopes");

        entity.Property(e => e.SupEnvSupplierEnvelopeId).HasColumnName("SupEnv__SupplierEnvelopeID");
        entity.Property(e => e.AltEnvAlternateSupplierEnvelopeId).HasColumnName("AltEnv__AlternateSupplierEnvelopeID");
        entity.Property(e => e.AltEnvDeleted).HasColumnName("AltEnv__Deleted");
        entity.Property(e => e.AltEnvNotes)
                .HasMaxLength(255)
                .HasColumnName("AltEnv__Notes");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblAlternateEnvelope> entity);
}
