using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblVerseConfiguration : IEntityTypeConfiguration<TblVerse>
{
    public void Configure(EntityTypeBuilder<TblVerse> entity)
    {
        entity.HasKey(e => e.VerVerseId).HasName("tblGreetingCardVerses_PK");

        entity.ToTable("tblVerses");

        entity.HasIndex(e => e.VerVerseNumber, "tblVerses_IX1");

        entity.Property(e => e.VerVerseId).HasColumnName("Ver__VerseID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ModifiedBy).HasDefaultValue(1);
        entity.Property(e => e.ModifiedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ProTypProductTypeId)
                .HasDefaultValue(14)
                .HasColumnName("ProTyp__ProductTypeID");
        entity.Property(e => e.VerHorizontalVerseText)
                .HasMaxLength(2000)
                .HasColumnName("Ver__HorizontalVerseText");
        entity.Property(e => e.VerNotes)
                .HasMaxLength(2999)
                .IsUnicode(false)
                .HasColumnName("Ver__Notes");
        entity.Property(e => e.VerVerseNumber)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("Ver__VerseNumber");
        entity.Property(e => e.VerVerseYear)
                .HasDefaultValue(2003)
                .HasColumnName("Ver__VerseYear");
        entity.Property(e => e.VerVerticalVerseText)
                .HasMaxLength(2000)
                .HasColumnName("Ver__VerticalVerseText");

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblVerses)
                .HasForeignKey(d => d.ModifiedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblVerses_tblUsers");

        entity.HasOne(d => d.ProTypProductType).WithMany(p => p.TblVerses)
                .HasForeignKey(d => d.ProTypProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblVerses_ProductType");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblVerse> entity);
}
