using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AreaConfiguration : IEntityTypeConfiguration<Area>
{
    public void Configure(EntityTypeBuilder<Area> entity)
    {
        entity.ToTable("Area");

        entity.HasIndex(e => e.AreaTypeId, "Area_IX1");

        entity.HasIndex(e => e.LayoutId, "IX_Area_LayoutId");

        entity.Property(e => e.AreaMode).HasMaxLength(50);
        entity.Property(e => e.AreaNameId).HasColumnName("AreaNameID");
        entity.Property(e => e.ColorHex)
                .HasMaxLength(15)
                .IsUnicode(false);
        entity.Property(e => e.EntityCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.EntityUpdated).HasColumnType("datetime");
        entity.Property(e => e.EntityUpdatedBy).HasMaxLength(50);
        entity.Property(e => e.HorizontalAlignmentTypeId).HasDefaultValue(1);
        entity.Property(e => e.InkColorGroupId).HasDefaultValue(1);
        entity.Property(e => e.PlateImage).HasMaxLength(255);
        entity.Property(e => e.PreviewImage).HasMaxLength(255);
        entity.Property(e => e.VerticalAlignmentTypeId).HasDefaultValue(1);

        entity.HasOne(d => d.AreaName).WithMany(p => p.Areas)
                .HasForeignKey(d => d.AreaNameId)
                .HasConstraintName("FK_Area_AreaName");

        entity.HasOne(d => d.AreaType).WithMany(p => p.Areas)
                .HasForeignKey(d => d.AreaTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Area_AreaType");

        entity.HasOne(d => d.HorizontalAlignmentType).WithMany(p => p.Areas)
                .HasForeignKey(d => d.HorizontalAlignmentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Area_tblHorizontalAlignmentTypes");

        entity.HasOne(d => d.InkColorGroup).WithMany(p => p.Areas)
                .HasForeignKey(d => d.InkColorGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Area_InkColorGroup");

        entity.HasOne(d => d.Layout).WithMany(p => p.Areas)
                .HasForeignKey(d => d.LayoutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Area_Layout");

        entity.HasOne(d => d.VerticalAlignmentType).WithMany(p => p.Areas)
                .HasForeignKey(d => d.VerticalAlignmentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Area_tblVerticalAlignmentTypes");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Area> entity);
}
