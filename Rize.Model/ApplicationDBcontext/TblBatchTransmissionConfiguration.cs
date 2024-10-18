using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblBatchTransmissionConfiguration : IEntityTypeConfiguration<TblBatchTransmission>
{
    public void Configure(EntityTypeBuilder<TblBatchTransmission> entity)
    {
        entity.HasKey(e => e.BatTraBatchTransmissionsId);

        entity.ToTable("tblBatchTransmissions");

        entity.HasIndex(e => e.BatTraDateTimeSubmitted, "tblBatchTransmissions_IX1");

        entity.Property(e => e.BatTraBatchTransmissionsId).HasColumnName("BatTra__BatchTransmissionsID");
        entity.Property(e => e.BatTraDateTimeCompleted)
                .HasColumnType("datetime")
                .HasColumnName("BatTra__DateTimeCompleted");
        entity.Property(e => e.BatTraDateTimeSubmitted)
                .HasColumnType("datetime")
                .HasColumnName("BatTra__DateTimeSubmitted");
        entity.Property(e => e.BatTraHasError)
                .HasDefaultValue(false)
                .HasColumnName("BatTra__HasError");
        entity.Property(e => e.BitTraBatchLog).HasColumnName("BitTra__BatchLog");
        entity.Property(e => e.UserId)
                .HasDefaultValue(1)
                .HasColumnName("UserID");

        entity.HasOne(d => d.User).WithMany(p => p.TblBatchTransmissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBatchTransmissions_tblUsers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblBatchTransmission> entity);
}
