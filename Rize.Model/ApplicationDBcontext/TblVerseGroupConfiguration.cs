using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblVerseGroupConfiguration : IEntityTypeConfiguration<TblVerseGroup>
{
    public void Configure(EntityTypeBuilder<TblVerseGroup> entity)
    {
        entity.HasKey(e => e.VerGroVerseGroupId).HasName("tblVerseGroups_PK");

        entity.ToTable("tblVerseGroups");

        entity.Property(e => e.VerGroVerseGroupId).HasColumnName("VerGro__VerseGroupID");
        entity.Property(e => e.AvailableInPv3).HasColumnName("AvailableInPV3");
        entity.Property(e => e.FriendlyName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ParentId).HasColumnName("ParentID");
        entity.Property(e => e.VerGroDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("VerGro__Description");
        entity.Property(e => e.VerGroVerseGroupYear)
                .HasDefaultValue(2002)
                .HasColumnName("VerGro__VerseGroupYear");

        entity.HasMany(d => d.VerVerses).WithMany(p => p.VerGroVerseGroups)
            .UsingEntity<Dictionary<string, object>>(
                "TblVerseGroupVerse",
                r => r.HasOne<TblVerse>().WithMany()
                        .HasForeignKey("VerVerseId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_tblVerseGroupVerses_tblVerses"),
                l => l.HasOne<TblVerseGroup>().WithMany()
                        .HasForeignKey("VerGroVerseGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("tblVerseGroups_tblVerseGroupVerses_FK1"),
                j =>
                {
                    j.HasKey("VerGroVerseGroupId", "VerVerseId").HasName("tblVerseGroupVerses_PK");
                    j.ToTable("tblVerseGroupVerses");
                   j.IndexerProperty<int>("VerGroVerseGroupId")
                            .HasDefaultValue(31)
                            .HasColumnName("VerGro__VerseGroupID");
                   j.IndexerProperty<int>("VerVerseId").HasColumnName("Ver__VerseID");
            });

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblVerseGroup> entity);
}
