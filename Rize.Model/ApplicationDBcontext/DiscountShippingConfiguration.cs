using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DiscountShippingConfiguration : IEntityTypeConfiguration<DiscountShipping>
{
    public void Configure(EntityTypeBuilder<DiscountShipping> entity)
    {
        entity.ToTable("DiscountShipping");

        entity.Property(e => e.DiscountShippingId).HasDefaultValueSql("(newid())");
        entity.Property(e => e.EndDate).HasColumnType("datetime");
        entity.Property(e => e.Price).HasColumnType("decimal(16, 2)");
        entity.Property(e => e.StartDate).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DiscountShipping> entity);
}
