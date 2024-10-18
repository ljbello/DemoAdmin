using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderTypeConfiguration : IEntityTypeConfiguration<TblOrderType>
{
    public void Configure(EntityTypeBuilder<TblOrderType> entity)
    {
        entity.HasKey(e => e.OrdTypOrderTypeId);

        entity.ToTable("tblOrderTypes");

        entity.Property(e => e.OrdTypOrderTypeId)
                .ValueGeneratedNever()
                .HasColumnName("OrdTyp__OrderTypeID");
        entity.Property(e => e.OrdTypDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("OrdTyp__Description");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderType> entity);
}
