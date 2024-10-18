using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblDiscountTypeConfiguration : IEntityTypeConfiguration<TblDiscountType>
{
    public void Configure(EntityTypeBuilder<TblDiscountType> entity)
    {
        entity.HasKey(e => e.DisTypDiscountTypeId).HasName("tblDiscountTypes_PK");

        entity.ToTable("tblDiscountTypes");

        entity.Property(e => e.DisTypDiscountTypeId).HasColumnName("DisTyp__DiscountTypeID");
        entity.Property(e => e.Class)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ClassId).HasColumnName("ClassID");
        entity.Property(e => e.DisTypDiscountTypeDescription)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DisTyp__DiscountTypeDescription");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblDiscountType> entity);
}
