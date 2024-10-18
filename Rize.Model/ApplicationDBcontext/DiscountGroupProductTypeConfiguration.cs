using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DiscountGroupProductTypeConfiguration : IEntityTypeConfiguration<DiscountGroupProductType>
{
    public void Configure(EntityTypeBuilder<DiscountGroupProductType> entity)
    {
        entity.ToTable("DiscountGroupProductType");

        entity.Property(e => e.DiscountGroupProductTypeId).HasColumnName("DiscountGroupProductTypeID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.DiscountGroupId).HasColumnName("DiscountGroupID");
        entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

        entity.HasOne(d => d.DiscountGroup).WithMany(p => p.DiscountGroupProductTypes)
                .HasForeignKey(d => d.DiscountGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountGroupProductType_DiscountGroup");

        entity.HasOne(d => d.ProductType).WithMany(p => p.DiscountGroupProductTypes)
                .HasForeignKey(d => d.ProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountGroupProductType_ProductType");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DiscountGroupProductType> entity);
}
