using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class EnvelopeConfiguration : IEntityTypeConfiguration<Envelope>
{
    public void Configure(EntityTypeBuilder<Envelope> entity)
    {
        entity.HasKey(e => e.EnvEnvelopeId).HasName("Envelopes_PK");

        entity.ToTable("Envelope");

        entity.Property(e => e.EnvEnvelopeId).HasColumnName("Env__EnvelopeID");
        entity.Property(e => e.Description).HasMaxLength(600);
        entity.Property(e => e.EnvTypEnvelopeTypeId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EnvTyp__EnvelopeTypeID");
        entity.Property(e => e.Name)
                .HasMaxLength(48)
                .IsUnicode(false);

        entity.HasOne(d => d.EnvTypEnvelopeType).WithMany(p => p.Envelopes)
                .HasForeignKey(d => d.EnvTypEnvelopeTypeId)
                .HasConstraintName("tblEnvelopeTypes_Envelope_FK");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Envelope> entity);
}
