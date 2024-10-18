using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderInvoicesOrderLineConfiguration : IEntityTypeConfiguration<TblOrderInvoicesOrderLine>
{
    public void Configure(EntityTypeBuilder<TblOrderInvoicesOrderLine> entity)
    {
        entity.HasKey(e => e.OrdInvOrdLinOrderInvoiceOrderLineId).HasName("PK_tblOrderInvoicesOrderLines_1");

        entity.ToTable("tblOrderInvoicesOrderLines");

        entity.HasIndex(e => new { e.OrdInvOrderInvoiceId, e.OrdLinOrderLineId, e.OrdInvOrdLinDescription, e.OrdInvOrdLinQuantity, e.OrdInvOrdLinUnitPrice, e.OrdInvOrdLinSubtotal, e.OrdInvOrdLinSupplierPartId }, "IX_tblOrderInvoicesOrderLines").IsUnique();

        entity.Property(e => e.OrdInvOrdLinOrderInvoiceOrderLineId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("OrdInvOrdLin__OrderInvoiceOrderLineID");
        entity.Property(e => e.OrdInvOrdLinDescription)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("OrdInvOrdLin__Description");
        entity.Property(e => e.OrdInvOrdLinQuantity).HasColumnName("OrdInvOrdLin__Quantity");
        entity.Property(e => e.OrdInvOrdLinSubtotal)
                .HasColumnType("money")
                .HasColumnName("OrdInvOrdLin__Subtotal");
        entity.Property(e => e.OrdInvOrdLinSupplierPartId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("OrdInvOrdLin__SupplierPartID");
        entity.Property(e => e.OrdInvOrdLinUnitPrice)
                .HasColumnType("money")
                .HasColumnName("OrdInvOrdLin__UnitPrice");
        entity.Property(e => e.OrdInvOrderInvoiceId).HasColumnName("OrdInv__OrderInvoiceID");
        entity.Property(e => e.OrdLinOrderLineId).HasColumnName("OrdLin__OrderLineID");

        entity.HasOne(d => d.OrdInvOrderInvoice).WithMany(p => p.TblOrderInvoicesOrderLines)
                .HasForeignKey(d => d.OrdInvOrderInvoiceId)
                .HasConstraintName("FK_tblOrderInvoicesOrderLines_tblOrderInvoices");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderInvoicesOrderLine> entity);
}
