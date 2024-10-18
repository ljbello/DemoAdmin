using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCouponDiscountConfiguration : IEntityTypeConfiguration<TblCouponDiscount>
{
    public void Configure(EntityTypeBuilder<TblCouponDiscount> entity)
    {
        entity.HasKey(e => e.CouDisCouponDiscountId).HasName("tblCouponDiscounts_PK");

        entity.ToTable("tblCouponDiscounts");

        entity.HasIndex(e => e.CouCouponId, "tblCouponDiscounts");

        entity.HasIndex(e => e.DisDiscountId, "tblCouponDiscounts_IX2");

        entity.Property(e => e.CouDisCouponDiscountId).HasColumnName("CouDis__CouponDiscountID");
        entity.Property(e => e.CouCouponId).HasColumnName("Cou__CouponID");
        entity.Property(e => e.DisDiscountId).HasColumnName("Dis__DiscountID");
        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");

        entity.HasOne(d => d.CouCoupon).WithMany(p => p.TblCouponDiscounts)
                .HasForeignKey(d => d.CouCouponId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblCoupons_tblCouponDiscounts_FK1");

        entity.HasOne(d => d.DisDiscount).WithMany(p => p.TblCouponDiscounts)
                .HasForeignKey(d => d.DisDiscountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblDiscounts_tblCouponDiscounts_FK1");

        entity.HasOne(d => d.StoStore).WithMany(p => p.TblCouponDiscounts)
                .HasForeignKey(d => d.StoStoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCouponDiscounts_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCouponDiscount> entity);
}
