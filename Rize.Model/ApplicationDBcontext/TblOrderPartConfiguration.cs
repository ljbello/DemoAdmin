using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderPartConfiguration : IEntityTypeConfiguration<TblOrderPart>
{
    public void Configure(EntityTypeBuilder<TblOrderPart> entity)
    {
        entity.HasKey(e => e.ParOrderPartId).HasName("tblOrderParts_PK");

        entity.ToTable("tblOrderParts", tb =>
                {
                    tb.HasTrigger("tblorderparts_UpdateDate");
                    tb.HasTrigger("tr_OrderParts_OrderLastUpdatedDate");
                });

        entity.HasIndex(e => new { e.ParOrderPartId, e.OrdOrderId }, "_dta_index_tblOrderParts_7_1294627655__K1_K2").HasFillFactor(95);

        entity.HasIndex(e => new { e.OrdOrderId, e.ParOrderPartId }, "_dta_index_tblOrderParts_7_1294627655__K2_K1").HasFillFactor(95);

        entity.HasIndex(e => new { e.ParOrderPartId, e.OrdOrderId, e.SupSupplierId }, "_dta_index_tblOrderParts_7_728415156__K1_K2_K3");

        entity.HasIndex(e => e.CreateDate, "tblOrderParts_CreateDate");

        entity.HasIndex(e => e.OrdOrderId, "tblOrderParts_IX1");

        entity.HasIndex(e => e.SupSupplierId, "tblOrderParts_IX2");

        entity.Property(e => e.ParOrderPartId).HasColumnName("Par__OrderPartID");
        entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.DelinquentInvoiceEmailSent).HasColumnType("datetime");
        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");
        entity.Property(e => e.ParCxmlpart).HasColumnName("Par__CXMLPart");
        entity.Property(e => e.ParIcsmxmlpart).HasColumnName("Par__ICSMXMLPart");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");
        entity.Property(e => e.UpdateDate).HasColumnType("datetime");

        entity.HasOne(d => d.OrdOrder).WithMany(p => p.TblOrderParts)
                .HasForeignKey(d => d.OrdOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblOrderParts_tblOrders");

        entity.HasOne(d => d.SupSupplier).WithMany(p => p.TblOrderParts)
                .HasForeignKey(d => d.SupSupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblOrderParts_tblSuppliers_FK1");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderPart> entity);
}
