using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrdersCouponConfiguration : IEntityTypeConfiguration<TblOrdersCoupon>
{
    public void Configure(EntityTypeBuilder<TblOrdersCoupon> entity)
    {
        entity.HasKey(e => e.OrdCouOrderCouponId);

        entity.ToTable("tblOrdersCoupons");

        entity.HasIndex(e => e.OrdOrderId, "tblOrdersCoupons_IX1");

        entity.HasIndex(e => e.CouCouponId, "tblOrdersCoupons_IX2");

        entity.Property(e => e.OrdCouOrderCouponId).HasColumnName("OrdCou__OrderCouponID");
        entity.Property(e => e.CouCouponId).HasColumnName("Cou__CouponID");
        entity.Property(e => e.CouponTrackingCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.DisDiscountId).HasColumnName("Dis__DiscountID");
        entity.Property(e => e.OrdCouAdditionalDiscountTotal)
                .HasColumnType("money")
                .HasColumnName("OrdCou__AdditionalDiscountTotal");
        entity.Property(e => e.OrdCouVariableDiscountCode)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("OrdCou__VariableDiscountCode");
        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");

        entity.HasOne(d => d.CouCoupon).WithMany(p => p.TblOrdersCoupons)
                .HasForeignKey(d => d.CouCouponId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblOrdersCoupons_tblCoupons");

        entity.HasOne(d => d.DisDiscount).WithMany(p => p.TblOrdersCoupons)
                .HasForeignKey(d => d.DisDiscountId)
                .HasConstraintName("FK_tblOrdersCoupons_tblDiscounts");

        entity.HasOne(d => d.OrdOrder).WithMany(p => p.TblOrdersCoupons)
                .HasForeignKey(d => d.OrdOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblOrdersCoupons_Order");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrdersCoupon> entity);
}
