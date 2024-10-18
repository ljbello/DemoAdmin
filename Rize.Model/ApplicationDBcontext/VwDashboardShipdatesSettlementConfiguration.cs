using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VwDashboardShipdatesSettlementConfiguration : IEntityTypeConfiguration<VwDashboardShipdatesSettlement>
{
    public void Configure(EntityTypeBuilder<VwDashboardShipdatesSettlement> entity)
    {
        entity
                .HasNoKey()
                .ToView("vw_dashboard_shipdatesSettlement");

        entity.Property(e => e.LargestShipDate).HasColumnType("smalldatetime");
        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");
        entity.Property(e => e.OrderDate).HasColumnType("datetime");
        entity.Property(e => e.Settlement).HasColumnType("money");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VwDashboardShipdatesSettlement> entity);
}
