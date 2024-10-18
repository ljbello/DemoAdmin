using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblStoreSupplierRetailDiscountConfiguration : IEntityTypeConfiguration<TblStoreSupplierRetailDiscount>
{
    public void Configure(EntityTypeBuilder<TblStoreSupplierRetailDiscount> entity)
    {
        entity.HasKey(e => e.StoSupRetDisStoreSupplierRetailDiscountId);

        entity.ToTable("tblStoreSupplierRetailDiscounts", tb => tb.HasTrigger("tblStoreSupplierRetailDiscounts_Update"));

        entity.HasIndex(e => new { e.PriGroPricingGroupId, e.SupSupplierId }, "tblStoreSupplierRetailDiscounts_IX1");

        entity.Property(e => e.StoSupRetDisStoreSupplierRetailDiscountId).HasColumnName("StoSupRetDis__StoreSupplierRetailDiscountID");
        entity.Property(e => e.ModifiedBy).HasDefaultValue(1);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.PriGroPricingGroupId)
                .HasDefaultValue(2)
                .HasColumnName("PriGro__PricingGroupID");
        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");
        entity.Property(e => e.StoSupRetDisDiscount)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("StoSupRetDis__Discount");
        entity.Property(e => e.StoSupRetDisLowerLimit).HasColumnName("StoSupRetDis__LowerLimit");
        entity.Property(e => e.StoSupRetDisUpperLimit).HasColumnName("StoSupRetDis__UpperLimit");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblStoreSupplierRetailDiscounts)
                .HasForeignKey(d => d.ModifiedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoreSupplierRetailDiscounts_tblUsers");

        entity.HasOne(d => d.StoStore).WithMany(p => p.TblStoreSupplierRetailDiscounts)
                .HasForeignKey(d => d.StoStoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoreSupplierRetailDiscounts_tblStores");

        entity.HasOne(d => d.SupSupplier).WithMany(p => p.TblStoreSupplierRetailDiscounts)
                .HasForeignKey(d => d.SupSupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoreSupplierRetailDiscounts_tblSuppliers");

        entity.HasOne(d => d.TblPricingGroup).WithMany(p => p.TblStoreSupplierRetailDiscounts)
                .HasForeignKey(d => new { d.PriGroPricingGroupId, d.StoStoreId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoreSupplierRetailDiscounts_tblPricingGroups1");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblStoreSupplierRetailDiscount> entity);
}
