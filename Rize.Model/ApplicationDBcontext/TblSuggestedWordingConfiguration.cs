using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblSuggestedWordingConfiguration : IEntityTypeConfiguration<TblSuggestedWording>
{
    public void Configure(EntityTypeBuilder<TblSuggestedWording> entity)
    {
        entity.HasKey(e => e.SugWorSuggestedWordingId).HasName("PK_tblSuggestedWording_1");

        entity.ToTable("tblSuggestedWording");

        entity.Property(e => e.SugWorSuggestedWordingId).HasColumnName("SugWor__SuggestedWordingID");
        entity.Property(e => e.LayAreTypLayoutAreaTypeId).HasColumnName("LayAreTyp__LayoutAreaTypeID");
        entity.Property(e => e.SugWorOrientation)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("b")
                .IsFixedLength()
                .HasColumnName("SugWor__Orientation");
        entity.Property(e => e.SugWorXml)
                .IsUnicode(false)
                .HasColumnName("SugWor__XML");

        entity.HasOne(d => d.LayAreTypLayoutAreaType).WithMany(p => p.TblSuggestedWordings)
                .HasForeignKey(d => d.LayAreTypLayoutAreaTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSuggestedWording_tblLayoutAreaTypes");

        entity.HasMany(d => d.OccOccasions).WithMany(p => p.SugWorSuggestedWordings)
            .UsingEntity<Dictionary<string, object>>(
                "TblSuggestedWordingOccasion",
                r => r.HasOne<TblOccasion>().WithMany()
                        .HasForeignKey("OccOccasionId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_tblSuggestedWordingOccasion_tblOccasion"),
                l => l.HasOne<TblSuggestedWording>().WithMany()
                        .HasForeignKey("SugWorSuggestedWordingId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_tblSuggestedWordingOccasion_tblSuggestedWording"),
                j =>
                {
                    j.HasKey("SugWorSuggestedWordingId", "OccOccasionId").HasName("PK_tblVerseOccasionVerse");
                    j.ToTable("tblSuggestedWordingOccasion");
                   j.IndexerProperty<int>("SugWorSuggestedWordingId").HasColumnName("SugWor__SuggestedWordingID");
                   j.IndexerProperty<int>("OccOccasionId").HasColumnName("Occ__OccasionID");
            });

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblSuggestedWording> entity);
}
