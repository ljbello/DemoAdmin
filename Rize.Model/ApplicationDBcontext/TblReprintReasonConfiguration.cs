using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblReprintReasonConfiguration : IEntityTypeConfiguration<TblReprintReason>
{
    public void Configure(EntityTypeBuilder<TblReprintReason> entity)
    {
        entity.HasKey(e => e.RepReaReprintReasonId);

        entity.ToTable("tblReprintReasons");

        entity.Property(e => e.RepReaReprintReasonId).HasColumnName("RepRea__ReprintReasonID");
        entity.Property(e => e.DefaultFaultType)
                .HasMaxLength(64)
                .IsUnicode(false);
        entity.Property(e => e.RepReaDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RepRea__Description");
        entity.Property(e => e.RepReaSequence).HasColumnName("RepRea__Sequence");
        entity.Property(e => e.SearchLookup)
                .HasMaxLength(256)
                .IsUnicode(false);
        entity.Property(e => e.SupplierErrorCode)
                .HasMaxLength(64)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblReprintReason> entity);
}
