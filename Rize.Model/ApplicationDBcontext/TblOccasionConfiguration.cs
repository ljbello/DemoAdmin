using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOccasionConfiguration : IEntityTypeConfiguration<TblOccasion>
{
    public void Configure(EntityTypeBuilder<TblOccasion> entity)
    {
        entity.HasKey(e => e.OccOccasionId).HasName("PK_tblVerseOccasion");

        entity.ToTable("tblOccasion");

        entity.Property(e => e.OccOccasionId).HasColumnName("Occ__OccasionID");
        entity.Property(e => e.OccDescription)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Occ__Description");

        entity.HasMany(d => d.VerGroVerseGroups).WithMany(p => p.OccOccasions)
            .UsingEntity<Dictionary<string, object>>(
                "TblOccasionVerseGroup",
                r => r.HasOne<TblVerseGroup>().WithMany()
                        .HasForeignKey("VerGroVerseGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_tblOccasionVerseGroup_tblVerseGroups"),
                l => l.HasOne<TblOccasion>().WithMany()
                        .HasForeignKey("OccOccasionId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_tblOccasionVerseGroup_tblOccasion"),
                j =>
                {
                    j.HasKey("OccOccasionId", "VerGroVerseGroupId");
                    j.ToTable("tblOccasionVerseGroup");
                   j.IndexerProperty<int>("OccOccasionId").HasColumnName("Occ__OccasionID");
                   j.IndexerProperty<int>("VerGroVerseGroupId").HasColumnName("VerGro__VerseGroupID");
            });

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOccasion> entity);
}
