using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblTypestyleConfiguration : IEntityTypeConfiguration<TblTypestyle>
{
    public void Configure(EntityTypeBuilder<TblTypestyle> entity)
    {
        entity.HasKey(e => e.TypTypestyleId).HasName("tblTypestyles_PK");

        entity.ToTable("tblTypestyles");

        entity.Property(e => e.TypTypestyleId).HasColumnName("Typ__TypestyleID");
        entity.Property(e => e.FileName)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.ModifiedBy).HasDefaultValue(1);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.Pdfenable).HasColumnName("PDFEnable");
        entity.Property(e => e.ProTypProductTypeId).HasColumnName("ProTyp__ProductTypeID");
        entity.Property(e => e.Psname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PSName");
        entity.Property(e => e.Pv4enabled)
                .HasDefaultValue(false)
                .HasColumnName("PV4Enabled");
        entity.Property(e => e.SubtituteName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.TypDisplayName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Typ__DisplayName");
        entity.Property(e => e.TypPreviewEnabled).HasColumnName("Typ__PreviewEnabled");
        entity.Property(e => e.TypRestrictCaps).HasColumnName("Typ__RestrictCaps");
        entity.Property(e => e.TypSizeOffset).HasColumnName("Typ__SizeOffset");
        entity.Property(e => e.TypTypestyleCode)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Typ__TypestyleCode");
        entity.Property(e => e.TypTypestyleName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Typ__TypestyleName");
        entity.Property(e => e.TypTypestyleStyle)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("NEED_TO_UPDATE")
                .HasColumnName("Typ__TypestyleStyle");
        entity.Property(e => e.TypWindowsFontName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Typ__WindowsFontName");

        entity.HasOne(d => d.Group).WithMany(p => p.TblTypestyles)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK_tblTypestyles_FontGroup");

        entity.HasOne(d => d.ProTypProductType).WithMany(p => p.TblTypestyles)
                .HasForeignKey(d => d.ProTypProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTypestyles_ProductType");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblTypestyle> entity);
}
