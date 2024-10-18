using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblVerseModeConfiguration : IEntityTypeConfiguration<TblVerseMode>
{
    public void Configure(EntityTypeBuilder<TblVerseMode> entity)
    {
        entity.HasKey(e => e.VerModVerseModeId).HasName("tblVerseModes_PK");

        entity.ToTable("tblVerseModes");

        entity.Property(e => e.VerModVerseModeId).HasColumnName("VerMod__VerseModeID");
        entity.Property(e => e.VerModDescription)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("VerMod__Description");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblVerseMode> entity);
}
