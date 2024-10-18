using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblBatchTransmissionsOrderPartConfiguration : IEntityTypeConfiguration<TblBatchTransmissionsOrderPart>
{
    public void Configure(EntityTypeBuilder<TblBatchTransmissionsOrderPart> entity)
    {
        entity.ToTable("tblBatchTransmissionsOrderParts");

        entity.HasIndex(e => e.ParOrderPartId, "tblBatchTransmissionsOrderParts_IX1");

        entity.HasIndex(e => e.BatTraBatchTransmissionsId, "tblBatchTransmissionsOrderParts_IX2");

        entity.HasIndex(e => e.OrdOrderId, "tblBatchTransmissionsOrderParts_IX3");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.BatTraBatchTransmissionsId).HasColumnName("BatTra__BatchTransmissionsID");
        entity.Property(e => e.Icsmxmlpart).HasColumnName("ICSMXMLPart");
        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");
        entity.Property(e => e.ParOrderPartId).HasColumnName("Par__OrderPartID");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");

        entity.HasOne(d => d.BatTraBatchTransmissions).WithMany(p => p.TblBatchTransmissionsOrderParts)
                .HasForeignKey(d => d.BatTraBatchTransmissionsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBatchTransmissionsOrderParts_tblBatchTransmissions");

        entity.HasOne(d => d.OrdOrder).WithMany(p => p.TblBatchTransmissionsOrderParts)
                .HasForeignKey(d => d.OrdOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBatchTransmissionsOrderParts_Order");

        entity.HasOne(d => d.SupSupplier).WithMany(p => p.TblBatchTransmissionsOrderParts)
                .HasForeignKey(d => d.SupSupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBatchTransmissionsOrderParts_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblBatchTransmissionsOrderPart> entity);
}
