using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VwDashboardShipdateConfiguration : IEntityTypeConfiguration<VwDashboardShipdate>
{
    public void Configure(EntityTypeBuilder<VwDashboardShipdate> entity)
    {
        entity
                .HasNoKey()
                .ToView("vw_dashboard_shipdates");

        entity.Property(e => e.EarliestShipDate).HasColumnType("smalldatetime");
        entity.Property(e => e.LargestShipDate).HasColumnType("smalldatetime");
        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VwDashboardShipdate> entity);
}
