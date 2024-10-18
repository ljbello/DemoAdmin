using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DeliveryEstimationAuditHeaderConfiguration : IEntityTypeConfiguration<DeliveryEstimationAuditHeader>
{
    public void Configure(EntityTypeBuilder<DeliveryEstimationAuditHeader> entity)
    {
        entity.ToTable("DeliveryEstimationAuditHeader");

        entity.HasIndex(e => e.OrderLineId, "[DeliveryEstimationAuditHeader_IX1");

        entity.Property(e => e.DeliveryEstimationAuditHeaderId).HasColumnName("DeliveryEstimationAuditHeaderID");
        entity.Property(e => e.EstimatedShipDate).HasColumnType("datetime");
        entity.Property(e => e.EstimatedSubmitDate).HasColumnType("datetime");
        entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");
        entity.Property(e => e.SessionId).HasColumnName("SessionID");
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
        entity.Property(e => e.UpsbusinessDaysInTransit).HasColumnName("UPSBusinessDaysInTransit");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DeliveryEstimationAuditHeader> entity);
}
