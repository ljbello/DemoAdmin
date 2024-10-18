using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CouponGeneratedConfiguration : IEntityTypeConfiguration<CouponGenerated>
{
    public void Configure(EntityTypeBuilder<CouponGenerated> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__CouponGe__3214EC070E5740D8");

        entity.ToTable("CouponGenerated");

        entity.HasIndex(e => e.CouponId, "CouponGenerated_IX1");

        entity.HasIndex(e => e.PromoCode, "IX_CouponGenerated_PromoCode");

        entity.Property(e => e.CouponId).HasColumnName("CouponID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.PromoCode)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.RedeemedOn).HasColumnType("datetime");

        entity.HasOne(d => d.Coupon).WithMany(p => p.CouponGenerateds)
                .HasForeignKey(d => d.CouponId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CouponGenerated_tblCoupons");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CouponGenerated> entity);
}
