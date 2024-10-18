using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblVerticalAlignmentTypeConfiguration : IEntityTypeConfiguration<TblVerticalAlignmentType>
{
    public void Configure(EntityTypeBuilder<TblVerticalAlignmentType> entity)
    {
        entity.HasKey(e => e.VerAliTypVerticalAlignmentTypeId).HasName("PK_tblVerticalAlignmentTypes_1");

        entity.ToTable("tblVerticalAlignmentTypes");

        entity.Property(e => e.VerAliTypVerticalAlignmentTypeId)
                .ValueGeneratedNever()
                .HasColumnName("VerAliTyp__VerticalAlignmentTypeID");
        entity.Property(e => e.VerAliTypAlignmentName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VerAliTyp__AlignmentName");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblVerticalAlignmentType> entity);
}
