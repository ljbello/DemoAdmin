using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VOrderQuantityConfiguration : IEntityTypeConfiguration<VOrderQuantity>
{
    public void Configure(EntityTypeBuilder<VOrderQuantity> entity)
    {
        entity
                .HasNoKey()
                .ToView("vOrderQuantity");

        entity.Property(e => e.OrderId).HasColumnName("OrderID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VOrderQuantity> entity);
}
