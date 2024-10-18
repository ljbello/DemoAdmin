using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblSupplierPricingConfiguration : IEntityTypeConfiguration<TblSupplierPricing>
{
    public void Configure(EntityTypeBuilder<TblSupplierPricing> entity)
    {
        entity.HasKey(e => e.SupPriPricingGroupId);

        entity.ToTable("tblSupplierPricing");

        entity.HasIndex(e => e.SupPriPricingGroupId, "tblSupplierPricing_IX1");

        entity.Property(e => e.SupPriPricingGroupId).HasColumnName("SupPri__PricingGroupID");
        entity.Property(e => e.CreatedBy).HasDefaultValue(1);
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.SupPriPriceId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("SupPri__PriceID");
        entity.Property(e => e.SupPriPricingGroupDescription)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("SupPri__PricingGroupDescription");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblSupplierPricings)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblSupplierPricing_tblUsers");

        entity.HasOne(d => d.Store).WithMany(p => p.TblSupplierPricings)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_tblSupplierPricing_tblStores");

        entity.HasOne(d => d.SupSupplier).WithMany(p => p.TblSupplierPricings)
                .HasForeignKey(d => d.SupSupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSupplierPricing_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblSupplierPricing> entity);
}
