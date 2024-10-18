using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblAuthorizationEcheckTypeConfiguration : IEntityTypeConfiguration<TblAuthorizationEcheckType>
{
    public void Configure(EntityTypeBuilder<TblAuthorizationEcheckType> entity)
    {
        entity.HasKey(e => e.AutEchTypAuthorizationEcheckTypeId);

        entity.ToTable("tblAuthorizationECheckTypes");

        entity.Property(e => e.AutEchTypAuthorizationEcheckTypeId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("AutEchTyp_AuthorizationECheckTypeID");
        entity.Property(e => e.AutEchTypDescription)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("AutEchTyp_Description");
        entity.Property(e => e.AutEchTypNotes)
                .HasMaxLength(4048)
                .IsUnicode(false)
                .HasColumnName("AutEchTyp_Notes");
        entity.Property(e => e.AutEchTypSequence).HasColumnName("AutEchTyp_Sequence");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblAuthorizationEcheckType> entity);
}
