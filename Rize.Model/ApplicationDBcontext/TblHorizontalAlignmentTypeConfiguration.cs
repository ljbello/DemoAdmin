using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblHorizontalAlignmentTypeConfiguration : IEntityTypeConfiguration<TblHorizontalAlignmentType>
{
    public void Configure(EntityTypeBuilder<TblHorizontalAlignmentType> entity)
    {
        entity.HasKey(e => e.HorAliTypHorizontalAlignmentId);

        entity.ToTable("tblHorizontalAlignmentTypes");

        entity.Property(e => e.HorAliTypHorizontalAlignmentId)
                .ValueGeneratedNever()
                .HasColumnName("HorAliTyp__HorizontalAlignmentID");
        entity.Property(e => e.HorAliTypAlignmentName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HorAliTyp__AlignmentName");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblHorizontalAlignmentType> entity);
}
