using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class InventoryMastReportAuditConfiguration : IEntityTypeConfiguration<InventoryMastReportAudit>
{
    public void Configure(EntityTypeBuilder<InventoryMastReportAudit> entity)
    {
        entity
                .HasNoKey()
                .ToTable("InventoryMastReportAudit");

        entity.Property(e => e.AvailQ).HasColumnName("avail_q");
        entity.Property(e => e.Cads1).HasColumnName("CADS1");
        entity.Property(e => e.Cads3).HasColumnName("CADS3");
        entity.Property(e => e.Cads5).HasColumnName("CADS5");
        entity.Property(e => e.Cadsh).HasColumnName("CADSH");
        entity.Property(e => e.Cadsl).HasColumnName("CADSL");
        entity.Property(e => e.Inflight).HasColumnName("inflight");
        entity.Property(e => e.InsertDate).HasColumnType("datetime");
        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductID");
        entity.Property(e => e.ProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.Status).HasColumnName("status");
        entity.Property(e => e.StoProDisplayOffset).HasColumnName("StoPro__DisplayOffset");
        entity.Property(e => e.StoProNumberOfSales).HasColumnName("StoPro__NumberOfSales");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");
        entity.Property(e => e.SupplierNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.TStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("t_status");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<InventoryMastReportAudit> entity);
}
