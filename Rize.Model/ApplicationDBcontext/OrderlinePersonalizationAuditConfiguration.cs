using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderlinePersonalizationAuditConfiguration : IEntityTypeConfiguration<OrderlinePersonalizationAudit>
{
    public void Configure(EntityTypeBuilder<OrderlinePersonalizationAudit> entity)
    {
        entity.HasKey(e => e.OrderLinePersonalizationId);

        entity.ToTable("OrderlinePersonalizationAudit");

        entity.HasIndex(e => e.OrderLineId, "OrderLinePersonalizationAudit_IX1");

        entity.HasIndex(e => e.DateChanged, "OrderlinePersonalizationAudit_IX2");

        entity.Property(e => e.OrderLinePersonalizationId).HasColumnName("OrderLinePersonalizationID");
        entity.Property(e => e.ActionTaken)
                .HasMaxLength(10)
                .IsUnicode(false);
        entity.Property(e => e.Browser).HasMaxLength(800);
        entity.Property(e => e.DateChanged)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.EnvelopePrintingCode).HasDefaultValue(10);
        entity.Property(e => e.Notes).IsUnicode(false);
        entity.Property(e => e.PaperStockFinishId).HasColumnName("PaperStockFinishID");
        entity.Property(e => e.PersonalizationXml).HasColumnType("xml");
        entity.Property(e => e.PunchOutConfigId)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.PunchOutThumbnailUrl)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PunchOutThumbnailURL");
        entity.Property(e => e.SupplierEnvelopeId).HasColumnName("SupplierEnvelopeID");
        entity.Property(e => e.VariationId).HasColumnName("VariationID");
        entity.Property(e => e.VariationOptionId).HasMaxLength(100);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderlinePersonalizationAudit> entity);
}
