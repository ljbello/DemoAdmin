using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderInvoiceConfiguration : IEntityTypeConfiguration<TblOrderInvoice>
{
    public void Configure(EntityTypeBuilder<TblOrderInvoice> entity)
    {
        entity.HasKey(e => e.OrdInvOrderInvoiceId);

        entity.ToTable("tblOrderInvoices");

        entity.HasIndex(e => new { e.OrdOrderId, e.SupSupplierId, e.OrdInvInvoiceNumber }, "IX_tblOrderInvoices").IsUnique();

        entity.Property(e => e.OrdInvOrderInvoiceId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("OrdInv__OrderInvoiceID");
        entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
        entity.Property(e => e.OrdInvAdditionalCreditOrDebit)
                .HasColumnType("money")
                .HasColumnName("OrdInv__AdditionalCreditOrDebit");
        entity.Property(e => e.OrdInvComments)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("OrdInv__Comments");
        entity.Property(e => e.OrdInvDigitalPressOrPhoto)
                .HasDefaultValue(false)
                .HasColumnName("OrdInv__DigitalPress_Or_Photo");
        entity.Property(e => e.OrdInvInvoiceDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("OrdInv__InvoiceDate");
        entity.Property(e => e.OrdInvInvoiceNumber)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("OrdInv__InvoiceNumber");
        entity.Property(e => e.OrdInvInvoiceShipping)
                .HasColumnType("money")
                .HasColumnName("OrdInv__InvoiceShipping");
        entity.Property(e => e.OrdInvInvoiceSubTotal)
                .HasColumnType("money")
                .HasColumnName("OrdInv__InvoiceSubTotal");
        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");

        entity.HasOne(d => d.OrdOrder).WithMany(p => p.TblOrderInvoices)
                .HasForeignKey(d => d.OrdOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblOrderInvoices_Order");

        entity.HasOne(d => d.SupSupplier).WithMany(p => p.TblOrderInvoices)
                .HasForeignKey(d => d.SupSupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblOrderInvoices_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderInvoice> entity);
}
