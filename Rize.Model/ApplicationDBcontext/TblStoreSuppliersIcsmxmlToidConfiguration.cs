using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblStoreSuppliersIcsmxmlToidConfiguration : IEntityTypeConfiguration<TblStoreSuppliersIcsmxmlToid>
{
    public void Configure(EntityTypeBuilder<TblStoreSuppliersIcsmxmlToid> entity)
    {
        entity.ToTable("tblStoreSuppliersICSMxmlTOId");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");
        entity.Property(e => e.StoSupIcsmxmlToid)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("StoSup__ICSMxmlTOId");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");

        entity.HasOne(d => d.StoStore).WithMany(p => p.TblStoreSuppliersIcsmxmlToids)
                .HasForeignKey(d => d.StoStoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoreSuppliersICSMxmlTOId_tblStores");

        entity.HasOne(d => d.SupSupplier).WithMany(p => p.TblStoreSuppliersIcsmxmlToids)
                .HasForeignKey(d => d.SupSupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoreSuppliersICSMxmlTOId_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblStoreSuppliersIcsmxmlToid> entity);
}
