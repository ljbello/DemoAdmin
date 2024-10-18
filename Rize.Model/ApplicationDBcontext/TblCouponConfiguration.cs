using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCouponConfiguration : IEntityTypeConfiguration<TblCoupon>
{
    public void Configure(EntityTypeBuilder<TblCoupon> entity)
    {
        entity.HasKey(e => e.CouCouponId).HasName("tblCoupons_PK");

        entity.ToTable("tblCoupons");

        entity.HasIndex(e => e.StoreId, "tblCoupons_IX1");

        entity.HasIndex(e => e.CouClaimCode, "tblCoupons_IX2");

        entity.Property(e => e.CouCouponId).HasColumnName("Cou__CouponID");
        entity.Property(e => e.CampaignNotes).HasColumnType("text");
        entity.Property(e => e.CatCatalogId).HasColumnName("Cat__CatalogID");
        entity.Property(e => e.CostPerPiece).HasColumnType("money");
        entity.Property(e => e.CouBalance)
                .HasColumnType("money")
                .HasColumnName("Cou__Balance");
        entity.Property(e => e.CouClaimCode)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Cou__ClaimCode");
        entity.Property(e => e.CouCouponBriefDescription)
                .HasMaxLength(140)
                .IsUnicode(false)
                .HasColumnName("Cou__CouponBriefDescription");
        entity.Property(e => e.CouCouponCode)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Cou__CouponCode");
        entity.Property(e => e.CouDescription)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("Cou__Description");
        entity.Property(e => e.CouMadePublicEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Cou__MadePublicEndDate");
        entity.Property(e => e.CouMadePublicStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Cou__MadePublicStartDate");
        entity.Property(e => e.CouNumTimesValid).HasColumnName("Cou__NumTimesValid");
        entity.Property(e => e.CouNumTimesValidPerCustomerId).HasColumnName("Cou__NumTimesValidPerCustomerID");
        entity.Property(e => e.CouOriginalValue)
                .HasColumnType("money")
                .HasColumnName("Cou__OriginalValue");
        entity.Property(e => e.MailDate).HasColumnType("datetime");
        entity.Property(e => e.MaxReachedErrorMsg)
                .HasMaxLength(200)
                .IsUnicode(false);
        entity.Property(e => e.MaxUsageType).HasDefaultValue(1);
        entity.Property(e => e.StoreId)
                .HasDefaultValue(1)
                .HasColumnName("StoreID");

        entity.HasOne(d => d.Store).WithMany(p => p.TblCoupons)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCoupons_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCoupon> entity);
}
