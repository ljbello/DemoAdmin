using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblGraphicTypeConfiguration : IEntityTypeConfiguration<TblGraphicType>
{
    public void Configure(EntityTypeBuilder<TblGraphicType> entity)
    {
        entity.HasKey(e => e.GraTypGraphicTypeId).HasName("tblGraphicTypes_PK");

        entity.ToTable("tblGraphicTypes");

        entity.Property(e => e.GraTypGraphicTypeId)
                .ValueGeneratedNever()
                .HasColumnName("GraTyp__GraphicTypeID");
        entity.Property(e => e.GraTypAbbreviation)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("GraTyp__Abbreviation");
        entity.Property(e => e.GraTypDescription)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("GraTyp__Description");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblGraphicType> entity);
}
