using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderLineArtworkRequestConfiguration : IEntityTypeConfiguration<OrderLineArtworkRequest>
{
    public void Configure(EntityTypeBuilder<OrderLineArtworkRequest> entity)
    {
        entity.ToTable("OrderLineArtworkRequest");

        entity.HasIndex(e => e.OrderLineId, "OrderLineArtworkRequest_IX1");

        entity.HasIndex(e => e.OrderId, "OrderLineArtworkRequest_IX2");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.OrderId).HasColumnName("OrderID");
        entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");
        entity.Property(e => e.RequestId).HasColumnName("RequestID");
        entity.Property(e => e.RevisionNotes)
                .HasMaxLength(800)
                .IsUnicode(false);
        entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ThumbnailId).HasColumnName("ThumbnailID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderLineArtworkRequest> entity);
}
