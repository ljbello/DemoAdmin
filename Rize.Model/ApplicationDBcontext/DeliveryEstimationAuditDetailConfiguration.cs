using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DeliveryEstimationAuditDetailConfiguration : IEntityTypeConfiguration<DeliveryEstimationAuditDetail>
{
    public void Configure(EntityTypeBuilder<DeliveryEstimationAuditDetail> entity)
    {
        entity.HasKey(e => e.DeliveryEstimationAuditDetailId).HasName("PK_DeliveryEstimationAudit");

        entity.ToTable("DeliveryEstimationAuditDetail");

        entity.HasIndex(e => e.DeliveryEstimationAuditHeaderId, "DeliveryEstimationAuditDetail_IX1");

        entity.Property(e => e.DeliveryEstimationAuditDetailId).HasColumnName("DeliveryEstimationAuditDetailID");
        entity.Property(e => e.DeliveryEstimationAuditHeaderId).HasColumnName("DeliveryEstimationAuditHeaderID");
        entity.Property(e => e.DeliveryEstimationCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.DeliveryEstimationCategoryElement)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.DeliveryEstimationCategoryElementId).HasColumnName("DeliveryEstimationCategoryElementID");
        entity.Property(e => e.DeliveryEstimationCategoryId).HasColumnName("DeliveryEstimationCategoryID");
        entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DeliveryEstimationAuditDetail> entity);
}
