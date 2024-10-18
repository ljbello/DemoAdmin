using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblSampleCardStockOrderConfiguration : IEntityTypeConfiguration<TblSampleCardStockOrder>
{
    public void Configure(EntityTypeBuilder<TblSampleCardStockOrder> entity)
    {
        entity.HasKey(e => e.SampleCardStockOrderId).HasName("PK_SampleCardStockOrder");

        entity.ToTable("tblSampleCardStockOrders");

        entity.Property(e => e.SampleCardStockOrderId).HasColumnName("SampleCardStockOrderID");
        entity.Property(e => e.EmailException)
                .HasMaxLength(1024)
                .IsUnicode(false);
        entity.Property(e => e.OrderDate).HasColumnType("datetime");
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblSampleCardStockOrder> entity);
}
