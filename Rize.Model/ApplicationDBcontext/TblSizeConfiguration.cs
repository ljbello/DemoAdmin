using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblSizeConfiguration : IEntityTypeConfiguration<TblSize>
{
    public void Configure(EntityTypeBuilder<TblSize> entity)
    {
        entity.HasKey(e => e.SizSizeId).HasName("tblSizes_PK");

        entity.ToTable("tblSizes");

        entity.Property(e => e.SizSizeId).HasColumnName("Siz__SizeID");
        entity.Property(e => e.ProTypProductTypeId).HasColumnName("ProTyp__ProductTypeID");
        entity.Property(e => e.SizDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Siz__Description");
        entity.Property(e => e.SizImageViewCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Siz__ImageViewCode");

        entity.HasOne(d => d.ProTypProductType).WithMany(p => p.TblSizes)
                .HasForeignKey(d => d.ProTypProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSizes_ProductType");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblSize> entity);
}
