using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblProductIdsThatPricingGroupWasModifiedWithCarlsonCraftPriceGroupConfiguration : IEntityTypeConfiguration<TblProductIdsThatPricingGroupWasModifiedWithCarlsonCraftPriceGroup>
{
    public void Configure(EntityTypeBuilder<TblProductIdsThatPricingGroupWasModifiedWithCarlsonCraftPriceGroup> entity)
    {
        entity
                .HasNoKey()
                .ToTable("tblProductIDsThatPricingGroupWasModifiedWithCarlsonCraftPriceGroup");

        entity.Property(e => e.IId)
                .ValueGeneratedOnAdd()
                .HasColumnName("iID");
        entity.Property(e => e.IProductId).HasColumnName("iProductID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblProductIdsThatPricingGroupWasModifiedWithCarlsonCraftPriceGroup> entity);
}
