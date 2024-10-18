using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblLayoutAreaConfiguration : IEntityTypeConfiguration<TblLayoutArea>
{
    public void Configure(EntityTypeBuilder<TblLayoutArea> entity)
    {
        entity.HasKey(e => e.LayAreLayoutAreaId);

        entity.ToTable("tblLayoutAreas");

        entity.HasIndex(e => new { e.LayLayoutId, e.LayAreTypLayoutAreaTypeId }, "UK_tblLayoutAreas").IsUnique();

        entity.Property(e => e.LayAreLayoutAreaId).HasColumnName("LayAre__LayoutAreaID");
        entity.Property(e => e.HorAliTypHorizontalAlignmentTypeId).HasColumnName("HorAliTyp__HorizontalAlignmentTypeID");
        entity.Property(e => e.LayAreHeight).HasColumnName("LayAre__Height");
        entity.Property(e => e.LayAreLeft).HasColumnName("LayAre__Left");
        entity.Property(e => e.LayAreRotation).HasColumnName("LayAre__Rotation");
        entity.Property(e => e.LayAreTop).HasColumnName("LayAre__Top");
        entity.Property(e => e.LayAreTypLayoutAreaTypeId).HasColumnName("LayAreTyp__LayoutAreaTypeID");
        entity.Property(e => e.LayAreWidth).HasColumnName("LayAre__Width");
        entity.Property(e => e.LayLayoutId).HasColumnName("Lay__LayoutID");
        entity.Property(e => e.VerAliTypVerticalAlignmentTypeId).HasColumnName("VerAliTyp__VerticalAlignmentTypeID");

        entity.HasOne(d => d.HorAliTypHorizontalAlignmentType).WithMany(p => p.TblLayoutAreas)
                .HasForeignKey(d => d.HorAliTypHorizontalAlignmentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLayoutAreas_tblHorizontalAlignmentTypes");

        entity.HasOne(d => d.LayAreTypLayoutAreaType).WithMany(p => p.TblLayoutAreas)
                .HasForeignKey(d => d.LayAreTypLayoutAreaTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLayoutAreas_tblLayoutAreaTypes");

        entity.HasOne(d => d.LayLayout).WithMany(p => p.TblLayoutAreas)
                .HasForeignKey(d => d.LayLayoutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLayoutAreas_tblLayouts");

        entity.HasOne(d => d.VerAliTypVerticalAlignmentType).WithMany(p => p.TblLayoutAreas)
                .HasForeignKey(d => d.VerAliTypVerticalAlignmentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLayoutAreas_tblVerticalAlignmentTypes");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblLayoutArea> entity);
}
