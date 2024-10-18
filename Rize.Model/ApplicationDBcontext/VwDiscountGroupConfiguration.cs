using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VwDiscountGroupConfiguration : IEntityTypeConfiguration<VwDiscountGroup>
{
    public void Configure(EntityTypeBuilder<VwDiscountGroup> entity)
    {
        entity
                .HasNoKey()
                .ToView("VwDiscountGroup");

        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.DiscountGroupId).HasColumnName("DiscountGroupID");
        entity.Property(e => e.Discountamount)
                .HasColumnType("money")
                .HasColumnName("discountamount");
        entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
        entity.Property(e => e.Startqty).HasColumnName("startqty");
        entity.Property(e => e.Storeid).HasColumnName("storeid");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VwDiscountGroup> entity);
}
