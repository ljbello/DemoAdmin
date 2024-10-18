using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderCustomerMetricConfiguration : IEntityTypeConfiguration<OrderCustomerMetric>
{
    public void Configure(EntityTypeBuilder<OrderCustomerMetric> entity)
    {
        entity.HasKey(e => e.OrderId);

        entity.HasIndex(e => e.CustomerGroupId, "OrderCustomerMetrics_IX1");

        entity.HasIndex(e => e.OrderId, "OrderCustomrMetrics_IX2");

        entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("OrderID");
        entity.Property(e => e.AllTimeAov)
                .HasColumnType("money")
                .HasColumnName("AllTimeAOV");
        entity.Property(e => e.AllTimeValue).HasColumnType("money");
        entity.Property(e => e.CustomerGroupId).HasColumnName("CustomerGroupID");
        entity.Property(e => e.CustomerStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
        entity.Property(e => e.FirstOrderDate).HasColumnType("datetime");
        entity.Property(e => e.InsertTs)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("InsertTS");
        entity.Property(e => e.PreviousOrderDate).HasColumnType("datetime");
        entity.Property(e => e.ProductTypes)
                .HasMaxLength(500)
                .IsUnicode(false);
        entity.Property(e => e.TwelveMonthAov)
                .HasColumnType("money")
                .HasColumnName("TwelveMonthAOV");
        entity.Property(e => e.TwelveMonthOrderValue).HasColumnType("money");
        entity.Property(e => e.UpdateTs)
                .HasColumnType("datetime")
                .HasColumnName("UpdateTS");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderCustomerMetric> entity);
}
