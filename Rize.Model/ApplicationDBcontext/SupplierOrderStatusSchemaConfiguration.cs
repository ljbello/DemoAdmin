using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierOrderStatusSchemaConfiguration : IEntityTypeConfiguration<SupplierOrderStatusSchema>
{
    public void Configure(EntityTypeBuilder<SupplierOrderStatusSchema> entity)
    {
        entity.HasKey(e => e.SupplierOrderStatusSchemaId).HasName("PK_SupplierOrderStatusSchema1");

        entity.ToTable("SupplierOrderStatusSchema");

        entity.Property(e => e.SupplierOrderStatusSchemaId)
                .ValueGeneratedNever()
                .HasColumnName("SupplierOrderStatusSchemaID");
        entity.Property(e => e.Account)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Book)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.DiskFileName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Imprint)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Invoice)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.InvoiceDate)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.OrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.OrderStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Quantity)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.SheetName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ShipMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ShippingCharge)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ShippingDate)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ShippingMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.StatusDate)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.SupplierPart)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.TrackingLink)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.TrackingNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierOrderStatusSchema> entity);
}
