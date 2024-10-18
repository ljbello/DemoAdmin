using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AopexclusionProductConfiguration : IEntityTypeConfiguration<AopexclusionProduct>
{
    public void Configure(EntityTypeBuilder<AopexclusionProduct> entity)
    {
        entity.ToTable("AOPExclusionProduct");

        entity.Property(e => e.AopexclusionProductId).HasColumnName("AOPExclusionProductID");
        entity.Property(e => e.ProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AopexclusionProduct> entity);
}
