using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VOrdersWithAllOrderLinesNewOrderStatusConfiguration : IEntityTypeConfiguration<VOrdersWithAllOrderLinesNewOrderStatus>
{
    public void Configure(EntityTypeBuilder<VOrdersWithAllOrderLinesNewOrderStatus> entity)
    {
        entity
                .HasNoKey()
                .ToView("vOrdersWithAllOrderLinesNewOrderStatus");

        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderId");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VOrdersWithAllOrderLinesNewOrderStatus> entity);
}
