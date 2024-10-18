using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblChristmasCardsOrderLineCustomTextConfiguration : IEntityTypeConfiguration<TblChristmasCardsOrderLineCustomText>
{
    public void Configure(EntityTypeBuilder<TblChristmasCardsOrderLineCustomText> entity)
    {
        entity.HasKey(e => e.ChrCarOrdLinCusTexCustomTextId).HasName("tblChristmasCardsOrderLineCustomText_PK");

        entity.ToTable("tblChristmasCardsOrderLineCustomText");

        entity.HasIndex(e => new { e.OrdLinOrderLineId, e.AreAreaId, e.ChrCarOrdLinCusTexLineNumber }, "IX_tblChristmasCardsOrderLineCustomText").IsUnique();

        entity.Property(e => e.ChrCarOrdLinCusTexCustomTextId).HasColumnName("ChrCarOrdLinCusTex__CustomTextID");
        entity.Property(e => e.AreAreaId).HasColumnName("Are__AreaID");
        entity.Property(e => e.ChrCarOrdLinCusTexAmount)
                .HasColumnType("money")
                .HasColumnName("ChrCarOrdLinCusTex__Amount");
        entity.Property(e => e.ChrCarOrdLinCusTexLineNumber).HasColumnName("ChrCarOrdLinCusTex__LineNumber");
        entity.Property(e => e.ChrCarOrdLinCusTexPointSize)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("ChrCarOrdLinCusTex__PointSize");
        entity.Property(e => e.ChrCarOrdLinCusTexText)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("ChrCarOrdLinCusTex__Text");
        entity.Property(e => e.CreateTimeStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.OrdLinOrderLineId).HasColumnName("OrdLin__OrderLineID");
        entity.Property(e => e.TypTypestyleId).HasColumnName("Typ__TypestyleID");

        entity.HasOne(d => d.AreArea).WithMany(p => p.TblChristmasCardsOrderLineCustomTexts)
                .HasForeignKey(d => d.AreAreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblAreas_tblChristmasCardsOrderLineCustomText_FK1");

        entity.HasOne(d => d.OrdLinOrderLine).WithMany(p => p.TblChristmasCardsOrderLineCustomTexts)
                .HasForeignKey(d => d.OrdLinOrderLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblChristmasCardsOrderLineCustomText_tblChristmasCardsOrderLine");

        entity.HasOne(d => d.TypTypestyle).WithMany(p => p.TblChristmasCardsOrderLineCustomTexts)
                .HasForeignKey(d => d.TypTypestyleId)
                .HasConstraintName("tblTypestyles_tblChristmasCardsOrderLineCustomText_FK1");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblChristmasCardsOrderLineCustomText> entity);
}
