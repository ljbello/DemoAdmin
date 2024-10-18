using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblProductTypeConfiguration : IEntityTypeConfiguration<TblProductType>
{
    public void Configure(EntityTypeBuilder<TblProductType> entity)
    {
        entity.HasKey(e => e.ProTypProductTypeId).HasName("tblProductTypes_PK");

        entity.ToTable("tblProductTypes");

        entity.Property(e => e.ProTypProductTypeId).HasColumnName("ProTyp__ProductTypeID");
        entity.Property(e => e.AllowAop)
                .HasDefaultValue(true)
                .HasColumnName("AllowAOP");
        entity.Property(e => e.ImportProductTypeName).HasMaxLength(50);
        entity.Property(e => e.IsDigitalPress).HasDefaultValue(true);
        entity.Property(e => e.ProTypDescription)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("ProTyp__Description");
        entity.Property(e => e.ProductNumberPrefix)
                .HasMaxLength(2)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblProductType> entity);
}
