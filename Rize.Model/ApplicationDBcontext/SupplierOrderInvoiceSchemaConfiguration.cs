using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierOrderInvoiceSchemaConfiguration : IEntityTypeConfiguration<SupplierOrderInvoiceSchema>
{
    public void Configure(EntityTypeBuilder<SupplierOrderInvoiceSchema> entity)
    {
        entity.HasKey(e => e.SupplierOrderInvoiceSchemaId).HasName("PK_SupplierOrderInvoiceSchema1");

        entity.ToTable("SupplierOrderInvoiceSchema");

        entity.Property(e => e.SupplierOrderInvoiceSchemaId)
                .ValueGeneratedNever()
                .HasColumnName("SupplierOrderInvoiceSchemaID");
        entity.Property(e => e.Account)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.CreditOrDebit)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.DiskFileName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.EnvCharge)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Freight)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Handling)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Invoice)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.InvoiceDate)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.PoNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.SheetName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ShipmentMode)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ShippingCharge)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Total).HasMaxLength(50);
        entity.Property(e => e.TotalCharges)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Tracking)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierOrderInvoiceSchema> entity);
}
