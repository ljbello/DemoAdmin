using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierStatusDashboardConfiguration : IEntityTypeConfiguration<SupplierStatusDashboard>
{
    public void Configure(EntityTypeBuilder<SupplierStatusDashboard> entity)
    {
        entity.ToTable("SupplierStatusDashboard");

        entity.HasIndex(e => e.RunDate, "SupplierStatusDashboard_IX1");

        entity.HasIndex(e => e.RunDate, "SupplierStatusDashboard_IX2");

        entity.HasIndex(e => e.OrderId, "SupplierStatusDashboard_IX3");

        entity.Property(e => e.SupplierStatusDashboardId).HasDefaultValueSql("(newid())");
        entity.Property(e => e.FileName)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.Notes).IsUnicode(false);
        entity.Property(e => e.RunDate).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierStatusDashboard> entity);
}
