using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderAttachmentConfiguration : IEntityTypeConfiguration<OrderAttachment>
{
    public void Configure(EntityTypeBuilder<OrderAttachment> entity)
    {
        entity.ToTable("OrderAttachment");

        entity.HasIndex(e => e.OrderNoteId, "OrderAttachment_IX1");

        entity.HasIndex(e => e.OrderId, "OrderAttachment_IX2");

        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .IsUnicode(false);
        entity.Property(e => e.FileSize).HasColumnType("decimal(18, 2)");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderAttachment> entity);
}
