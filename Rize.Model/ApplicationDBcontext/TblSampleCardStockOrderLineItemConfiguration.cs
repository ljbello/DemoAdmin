using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblSampleCardStockOrderLineItemConfiguration : IEntityTypeConfiguration<TblSampleCardStockOrderLineItem>
{
    public void Configure(EntityTypeBuilder<TblSampleCardStockOrderLineItem> entity)
    {
        entity.HasKey(e => new { e.SampleCardStockOrderId, e.ProductId });

        entity.ToTable("tblSampleCardStockOrderLineItems");

        entity.Property(e => e.SampleCardStockOrderId).HasColumnName("SampleCardStockOrderID");
        entity.Property(e => e.ProductId).HasColumnName("ProductID");
        entity.Property(e => e.InternalNotes)
                .HasMaxLength(1024)
                .IsUnicode(false);
        entity.Property(e => e.SupplierProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false);

        entity.HasOne(d => d.SampleCardStockOrder).WithMany(p => p.TblSampleCardStockOrderLineItems)
                .HasForeignKey(d => d.SampleCardStockOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SampleCardStockOrderLineItems__SampleCardStockOrders");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblSampleCardStockOrderLineItem> entity);
}
