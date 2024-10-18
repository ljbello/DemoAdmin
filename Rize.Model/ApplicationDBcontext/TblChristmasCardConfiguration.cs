using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblChristmasCardConfiguration : IEntityTypeConfiguration<TblChristmasCard>
{
    public void Configure(EntityTypeBuilder<TblChristmasCard> entity)
    {
        entity.HasKey(e => e.ProProductId).HasName("tblGreetingCards_PK");

        entity.ToTable("tblChristmasCards", tb => tb.HasTrigger("tr_ChristmasCards_SupplierEnvelopeCode_UpdateInsert"));

        entity.HasIndex(e => new { e.ProProductId, e.ChrCarRecycled, e.ChrCarPhotoCard }, "tblChristmasCards_IX1");

        entity.Property(e => e.ProProductId)
                .ValueGeneratedNever()
                .HasColumnName("Pro__ProductID");
        entity.Property(e => e.AlbAlbumId)
                .HasDefaultValue(0)
                .HasColumnName("Alb__AlbumID");
        entity.Property(e => e.ChrCarAssemblyRequired).HasColumnName("ChrCar__AssemblyRequired");
        entity.Property(e => e.ChrCarCardOrientation)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("H")
                .HasColumnName("ChrCar__CardOrientation");
        entity.Property(e => e.ChrCarCardsPerPack).HasColumnName("ChrCar__CardsPerPack");
        entity.Property(e => e.ChrCarDefaultVerseId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("ChrCar__DefaultVerseID");
        entity.Property(e => e.ChrCarExtraPostageRequired).HasColumnName("ChrCar__ExtraPostageRequired");
        entity.Property(e => e.ChrCarHolidayCard)
                .HasDefaultValue(false)
                .HasColumnName("ChrCar__HolidayCard");
        entity.Property(e => e.ChrCarPanelCard).HasColumnName("ChrCar__PanelCard");
        entity.Property(e => e.ChrCarPhotoCard).HasColumnName("ChrCar__PhotoCard");
        entity.Property(e => e.ChrCarPostCard).HasColumnName("ChrCar__PostCard");
        entity.Property(e => e.ChrCarRecycled).HasColumnName("ChrCar__Recycled");
        entity.Property(e => e.ChrCarSoldInPacks).HasColumnName("ChrCar__SoldInPacks");
        entity.Property(e => e.ChrCarStandardVerseImageOrientation)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("H")
                .HasColumnName("ChrCar__StandardVerseImageOrientation");
        entity.Property(e => e.ChrCarVerseScaleFactor)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ChrCar__VerseScaleFactor");
        entity.Property(e => e.EnvEnvelopeId).HasColumnName("Env__EnvelopeID");
        entity.Property(e => e.InkColorGroupId).HasDefaultValue(1);
        entity.Property(e => e.SizSizeId).HasColumnName("Siz__SizeID");
        entity.Property(e => e.SupEnvSupplierEnvelopeCode)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("SupEnv__SupplierEnvelopeCode");

        entity.HasOne(d => d.EnvEnvelope).WithMany(p => p.TblChristmasCards)
                .HasForeignKey(d => d.EnvEnvelopeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblChristmasCards_Envelopes");

        entity.HasOne(d => d.InkColorGroup).WithMany(p => p.TblChristmasCards)
                .HasForeignKey(d => d.InkColorGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblChristmasCards_InkColorGroup");

        entity.HasOne(d => d.ProProduct).WithOne(p => p.TblChristmasCard)
                .HasForeignKey<TblChristmasCard>(d => d.ProProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblChristmasCards_tblProducts");

        entity.HasOne(d => d.SizSize).WithMany(p => p.TblChristmasCards)
                .HasForeignKey(d => d.SizSizeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblChristmasCards_tblSizes");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblChristmasCard> entity);
}
