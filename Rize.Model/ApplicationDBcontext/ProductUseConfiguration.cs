using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductUseConfiguration : IEntityTypeConfiguration<ProductUse>
{
    public void Configure(EntityTypeBuilder<ProductUse> entity)
    {
        entity.ToTable("ProductUse");

        entity.Property(e => e.ProductUseId).HasColumnName("ProductUseID");
        entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ProductUse1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProductUse");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductUse> entity);
}
