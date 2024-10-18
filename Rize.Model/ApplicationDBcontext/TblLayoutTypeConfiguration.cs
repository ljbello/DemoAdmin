using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblLayoutTypeConfiguration : IEntityTypeConfiguration<TblLayoutType>
{
    public void Configure(EntityTypeBuilder<TblLayoutType> entity)
    {
        entity.HasKey(e => e.LayTypLayoutTypeId);

        entity.ToTable("tblLayoutTypes");

        entity.Property(e => e.LayTypLayoutTypeId)
                .ValueGeneratedNever()
                .HasColumnName("LayTyp__LayoutTypeID");
        entity.Property(e => e.LayTypTypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LayTyp__TypeName");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblLayoutType> entity);
}
