using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ShippingPricingGroupConfiguration : IEntityTypeConfiguration<ShippingPricingGroup>
{
    public void Configure(EntityTypeBuilder<ShippingPricingGroup> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__Shipping__3214EC07DF2C153B");

        entity.ToTable("ShippingPricingGroup");

        entity.Property(e => e.CostPerPiece).HasColumnType("money");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ShippingPricingGroup> entity);
}
