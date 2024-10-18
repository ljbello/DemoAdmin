using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblAlbumConfiguration : IEntityTypeConfiguration<TblAlbum>
{
    public void Configure(EntityTypeBuilder<TblAlbum> entity)
    {
        entity.HasKey(e => e.AlbAlbumId).HasName("tblAlbums_PK");

        entity.ToTable("tblAlbums");

        entity.Property(e => e.AlbAlbumId).HasColumnName("Alb__AlbumID");
        entity.Property(e => e.AlbAbbreviation)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Alb__Abbreviation");
        entity.Property(e => e.AlbAlbumYear)
                .HasDefaultValue(2001)
                .HasColumnName("Alb__AlbumYear");
        entity.Property(e => e.AlbCarlsonCraftAlbumOrderCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Alb__CarlsonCraftAlbumOrderCode");
        entity.Property(e => e.AlbName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Alb__Name");
        entity.Property(e => e.AlbTypeTemp)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("HOL")
                .HasColumnName("Alb__Type_TEMP");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");

        entity.HasOne(d => d.SupSupplier).WithMany(p => p.TblAlbums)
                .HasForeignKey(d => d.SupSupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAlbums_tblSuppliers");

        entity.HasMany(d => d.VerVerses).WithMany(p => p.AlbAlbums)
            .UsingEntity<Dictionary<string, object>>(
                "TblAlbumVerse",
                r => r.HasOne<TblVerse>().WithMany()
                        .HasForeignKey("VerVerseId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("tblGreetingCardVerses_tblAlbumGreetingCardVerses_FK1"),
                l => l.HasOne<TblAlbum>().WithMany()
                        .HasForeignKey("AlbAlbumId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("tblAlbums_tblAlbumGreetingCardVerses_FK1"),
                j =>
                {
                    j.HasKey("AlbAlbumId", "VerVerseId").HasName("tblAlbumGreetingCardVerses_PK");
                    j.ToTable("tblAlbumVerses");
                   j.IndexerProperty<int>("AlbAlbumId").HasColumnName("Alb__AlbumID");
                   j.IndexerProperty<int>("VerVerseId").HasColumnName("Ver__VerseID");
            });

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblAlbum> entity);
}
