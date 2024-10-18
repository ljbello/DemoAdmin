using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblEnvelopeTypeConfiguration : IEntityTypeConfiguration<TblEnvelopeType>
{
    public void Configure(EntityTypeBuilder<TblEnvelopeType> entity)
    {
        entity.HasKey(e => e.EnvTypEnvelopeTypeId).HasName("tblEnvelopeTypes_PK");

        entity.ToTable("tblEnvelopeTypes");

        entity.Property(e => e.EnvTypEnvelopeTypeId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EnvTyp__EnvelopeTypeID");
        entity.Property(e => e.EnvTypAdditionalCostPer25)
                .HasColumnType("money")
                .HasColumnName("EnvTyp__AdditionalCostPer25");
        entity.Property(e => e.EnvTypDefaultRanking).HasColumnName("EnvTyp__DefaultRanking");
        entity.Property(e => e.EnvTypDescription)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("EnvTyp__Description");
        entity.Property(e => e.EnvTypDisplayOrder).HasColumnName("EnvTyp__DisplayOrder");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblEnvelopeType> entity);
}
