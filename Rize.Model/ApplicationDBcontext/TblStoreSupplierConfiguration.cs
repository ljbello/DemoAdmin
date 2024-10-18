using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblStoreSupplierConfiguration : IEntityTypeConfiguration<TblStoreSupplier>
{
    public void Configure(EntityTypeBuilder<TblStoreSupplier> entity)
    {
        entity.ToTable("tblStoreSuppliers");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");
        entity.Property(e => e.StoSupAccountNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("StoSup__AccountNumber");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");

        entity.HasOne(d => d.StoStore).WithMany(p => p.TblStoreSuppliers)
                .HasForeignKey(d => d.StoStoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoreSuppliers_tblStores");

        entity.HasOne(d => d.SupSupplier).WithMany(p => p.TblStoreSuppliers)
                .HasForeignKey(d => d.SupSupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoreSuppliers_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblStoreSupplier> entity);
}
