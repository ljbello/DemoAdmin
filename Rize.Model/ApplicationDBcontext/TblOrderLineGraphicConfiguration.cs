using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderLineGraphicConfiguration : IEntityTypeConfiguration<TblOrderLineGraphic>
{
    public void Configure(EntityTypeBuilder<TblOrderLineGraphic> entity)
    {
        entity.HasKey(e => e.OrdLinGraOrderLineGraphicId).HasName("tblOrderLineGraphics_PK");

        entity.ToTable("tblOrderLineGraphics");

        entity.Property(e => e.OrdLinGraOrderLineGraphicId).HasColumnName("OrdLinGra__OrderLineGraphicID");
        entity.Property(e => e.AreAreaId).HasColumnName("Are__AreaID");
        entity.Property(e => e.GraTypGraphicTypeId).HasColumnName("GraTyp__GraphicTypeID");
        entity.Property(e => e.OrdLinGraComment)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("OrdLinGra__Comment");
        entity.Property(e => e.OrdLinGraGraphicDirectory)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("OrdLinGra__GraphicDirectory");
        entity.Property(e => e.OrdLinGraGraphicFileName)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("OrdLinGra__GraphicFileName");
        entity.Property(e => e.OrdLinGraGraphicTcpipaddress)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("OrdLinGra__GraphicTCPIPAddress");
        entity.Property(e => e.OrdLinGraSequence).HasColumnName("OrdLinGra__Sequence");
        entity.Property(e => e.OrdLinGraShowInDieCut).HasColumnName("OrdLinGra__ShowInDieCut");
        entity.Property(e => e.OrdLinOrderLineId).HasColumnName("OrdLin__OrderLineID");

        entity.HasOne(d => d.AreArea).WithMany(p => p.TblOrderLineGraphics)
                .HasForeignKey(d => d.AreAreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblAreas_tblOrderLineGraphics_FK1");

        entity.HasOne(d => d.GraTypGraphicType).WithMany(p => p.TblOrderLineGraphics)
                .HasForeignKey(d => d.GraTypGraphicTypeId)
                .HasConstraintName("tblGraphicTypes_tblOrderLineGraphics_FK1");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderLineGraphic> entity);
}
