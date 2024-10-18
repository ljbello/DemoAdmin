using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderLineSubmissionGraphicFileConfiguration : IEntityTypeConfiguration<TblOrderLineSubmissionGraphicFile>
{
    public void Configure(EntityTypeBuilder<TblOrderLineSubmissionGraphicFile> entity)
    {
        entity.ToTable("tblOrderLineSubmissionGraphicFiles");

        entity.HasIndex(e => e.OrdLinOrderLineId, "tblOrderLineSubmissionGraphicFiles_IX1");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.AreAreaId).HasColumnName("Are__AreaID");
        entity.Property(e => e.OrdLinDtppart).HasColumnName("OrdLin__DTPPart");
        entity.Property(e => e.OrdLinOrderLineId).HasColumnName("OrdLin__OrderLineID");
        entity.Property(e => e.OrdLinSubGraFilDateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("OrdLinSubGraFil__DateCreated");
        entity.Property(e => e.OrdLinSubGraFilDateSubmitted)
                .HasColumnType("datetime")
                .HasColumnName("OrdLinSubGraFil__DateSubmitted");
        entity.Property(e => e.OrdLinSubGraFilDateVerified)
                .HasColumnType("datetime")
                .HasColumnName("OrdLinSubGraFil__DateVerified");
        entity.Property(e => e.OrdLinSubGraFilGraphicFileName)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("OrdLinSubGraFil__GraphicFileName");
        entity.Property(e => e.OrdSubStaOrderSubmissionStatusId).HasColumnName("OrdSubSta__OrderSubmissionStatusID");

        entity.HasOne(d => d.AreArea).WithMany(p => p.TblOrderLineSubmissionGraphicFiles)
                .HasForeignKey(d => d.AreAreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblOrderLineSubmissionGraphicFiles_tblAreas");

        entity.HasOne(d => d.OrdSubStaOrderSubmissionStatus).WithMany(p => p.TblOrderLineSubmissionGraphicFiles)
                .HasForeignKey(d => d.OrdSubStaOrderSubmissionStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblOrderLineSubmissionGraphicFiles_tblOrderSubmissionStatus");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderLineSubmissionGraphicFile> entity);
}
