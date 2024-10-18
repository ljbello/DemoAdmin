using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderSubmissionStatusConfiguration : IEntityTypeConfiguration<TblOrderSubmissionStatus>
{
    public void Configure(EntityTypeBuilder<TblOrderSubmissionStatus> entity)
    {
        entity.HasKey(e => e.OrdSubStaOrderSubmissionStatusId);

        entity.ToTable("tblOrderSubmissionStatus");

        entity.Property(e => e.OrdSubStaOrderSubmissionStatusId)
                .ValueGeneratedNever()
                .HasColumnName("OrdSubSta__OrderSubmissionStatusID");
        entity.Property(e => e.OrdSubStaDescription)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OrdSubSta__Description");
        entity.Property(e => e.OrdSubStaSequence).HasColumnName("OrdSubSta__Sequence");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderSubmissionStatus> entity);
}
