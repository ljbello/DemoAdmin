using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblLayoutAreaTypeConfiguration : IEntityTypeConfiguration<TblLayoutAreaType>
{
    public void Configure(EntityTypeBuilder<TblLayoutAreaType> entity)
    {
        entity.HasKey(e => e.LayAreTypLayoutAreaTypeId);

        entity.ToTable("tblLayoutAreaTypes");

        entity.Property(e => e.LayAreTypLayoutAreaTypeId)
                .ValueGeneratedNever()
                .HasColumnName("LayAreTyp__LayoutAreaTypeID");
        entity.Property(e => e.LayAreTypTypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LayAreTyp__TypeName");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblLayoutAreaType> entity);
}
