using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CustomerMetricsOrderProcessingConfiguration : IEntityTypeConfiguration<CustomerMetricsOrderProcessing>
{
    public void Configure(EntityTypeBuilder<CustomerMetricsOrderProcessing> entity)
    {
        entity
                .HasNoKey()
                .ToTable("CustomerMetricsOrderProcessing");

        entity.HasIndex(e => e.ProcessId, "CustomerMetricsOrderProcessing_IX1");

        entity.HasIndex(e => e.ProcessStatus, "CustomerMetricsOrderProcessing_IX2");

        entity.HasIndex(e => e.OrderId, "CustomerMetricsOrderProcessing_IX3");

        entity.Property(e => e.OrderId).HasColumnName("OrderID");
        entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        entity.Property(e => e.ProcessId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ProcessID");
        entity.Property(e => e.ProcessStatus)
                .HasMaxLength(20)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CustomerMetricsOrderProcessing> entity);
}
