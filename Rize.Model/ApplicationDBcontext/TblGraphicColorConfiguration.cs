using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblGraphicColorConfiguration : IEntityTypeConfiguration<TblGraphicColor>
{
    public void Configure(EntityTypeBuilder<TblGraphicColor> entity)
    {
        entity.HasKey(e => e.GraColGraphicColorId).HasName("tblGraphicColors_PK");

        entity.ToTable("tblGraphicColors");

        entity.Property(e => e.GraColGraphicColorId).HasColumnName("GraCol__GraphicColorID");
        entity.Property(e => e.GraColComment)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("GraCol__Comment");
        entity.Property(e => e.GraColImprintColor)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("GraCol__ImprintColor");
        entity.Property(e => e.GraColSequence).HasColumnName("GraCol__Sequence");
        entity.Property(e => e.OrdLinGraOrderLineGraphicId).HasColumnName("OrdLinGra__OrderLineGraphicID");

        entity.HasOne(d => d.OrdLinGraOrderLineGraphic).WithMany(p => p.TblGraphicColors)
                .HasForeignKey(d => d.OrdLinGraOrderLineGraphicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblOrderLineGraphics_tblGraphicColors_FK1");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblGraphicColor> entity);
}
