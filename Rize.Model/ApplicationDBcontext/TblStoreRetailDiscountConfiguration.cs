using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblStoreRetailDiscountConfiguration : IEntityTypeConfiguration<TblStoreRetailDiscount>
{
    public void Configure(EntityTypeBuilder<TblStoreRetailDiscount> entity)
    {
        entity.HasKey(e => e.StoRetDisStoreRetailDiscountId).HasName("tblStoreRetailDiscounts_PK");

        entity.ToTable("tblStoreRetailDiscounts");

        entity.Property(e => e.StoRetDisStoreRetailDiscountId).HasColumnName("StoRetDis__StoreRetailDiscountID");
        entity.Property(e => e.PriGroPricingGroupId)
                .HasDefaultValue(2)
                .HasColumnName("PriGro__PricingGroupID");
        entity.Property(e => e.StoRetDisDiscount)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("StoRetDis__Discount");
        entity.Property(e => e.StoRetDisLowerLimit).HasColumnName("StoRetDis__LowerLimit");
        entity.Property(e => e.StoRetDisUpperLimit).HasColumnName("StoRetDis__UpperLimit");
        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");

        entity.HasOne(d => d.StoStore).WithMany(p => p.TblStoreRetailDiscounts)
                .HasForeignKey(d => d.StoStoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoreRetailDiscounts_tblStores");

        entity.HasOne(d => d.TblPricingGroup).WithMany(p => p.TblStoreRetailDiscounts)
                .HasForeignKey(d => new { d.PriGroPricingGroupId, d.StoStoreId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoreRetailDiscounts_tblPricingGroups1");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblStoreRetailDiscount> entity);
}
