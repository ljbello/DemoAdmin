using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductionTypeConfiguration : IEntityTypeConfiguration<ProductionType>
{
    public void Configure(EntityTypeBuilder<ProductionType> entity)
    {
        entity.ToTable("ProductionType");

        entity.Property(e => e.ProductionTypeId).HasColumnName("ProductionTypeID");
        entity.Property(e => e.AllowAop)
                .HasDefaultValue(true)
                .HasColumnName("AllowAOP");
        entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ProductionType1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProductionType");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductionType> entity);
}
