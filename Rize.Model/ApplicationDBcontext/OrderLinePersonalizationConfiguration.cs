using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderLinePersonalizationConfiguration : IEntityTypeConfiguration<OrderLinePersonalization>
{
    public void Configure(EntityTypeBuilder<OrderLinePersonalization> entity)
    {
        entity.HasKey(e => e.OrderLineId).HasName("PK_OrderLinePersonalization_1");

        entity.ToTable("OrderLinePersonalization", tb =>
                {
                    tb.HasTrigger("OrderLinePersonalizationXML_Update");
                    tb.HasTrigger("OrderLinePersonalization_U");
                    tb.HasTrigger("OrderlinePersonalization_tr");
                    tb.HasTrigger("tr_OrderLinePersonalization_OrderLastUpdatedDate");
                });

        entity.HasIndex(e => e.EnvelopePrintingCode, "OrderLinePersonalization_IX2");

        entity.HasIndex(e => e.VariationId, "OrderLinePersonalization_IX3");

        entity.HasIndex(e => e.HasImageScan, "orderlinepersonalization_IX1");

        entity.Property(e => e.OrderLineId).ValueGeneratedNever();
        entity.Property(e => e.Browser).HasMaxLength(800);
        entity.Property(e => e.EnvelopePrintingCode).HasDefaultValue(10);
        entity.Property(e => e.HasImageScan).HasDefaultValue(false);
        entity.Property(e => e.LastEditNotes).IsUnicode(false);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.PersonalizationXml).HasColumnType("xml");
        entity.Property(e => e.PunchOutConfigId)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.PunchOutThumbnailUrl)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PunchOutThumbnailURL");
        entity.Property(e => e.VariationOptionId).HasMaxLength(100);

        entity.HasOne(d => d.OrderLine).WithOne(p => p.OrderLinePersonalization)
                .HasForeignKey<OrderLinePersonalization>(d => d.OrderLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderLinePersonalization_tblOrderLines");

        entity.HasOne(d => d.PaperstockFinish).WithMany(p => p.OrderLinePersonalizations)
                .HasForeignKey(d => d.PaperstockFinishId)
                .HasConstraintName("FK_OrderLinePersonalization_PaperStockFinish");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderLinePersonalization> entity);
}
