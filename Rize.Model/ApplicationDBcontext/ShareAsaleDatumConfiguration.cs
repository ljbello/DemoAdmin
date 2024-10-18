using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ShareAsaleDatumConfiguration : IEntityTypeConfiguration<ShareAsaleDatum>
{
    public void Configure(EntityTypeBuilder<ShareAsaleDatum> entity)
    {
        entity.ToTable("ShareASaleData");

        entity.Property(e => e.BannerName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.BannerNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
        entity.Property(e => e.BannerPage)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.BannerType)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.Comment).IsUnicode(false);
        entity.Property(e => e.Commission).HasColumnType("decimal(18, 2)");
        entity.Property(e => e.CommissionType)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.CouponCode)
                .HasMaxLength(30)
                .IsUnicode(false);
        entity.Property(e => e.DateOfClick).HasColumnType("datetime");
        entity.Property(e => e.DateOfReversal).HasColumnType("datetime");
        entity.Property(e => e.DateOfTrans).HasColumnType("datetime");
        entity.Property(e => e.IsMobile).HasDefaultValue(false);
        entity.Property(e => e.LastIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LastIP");
        entity.Property(e => e.LastReferer)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.LockDate).HasColumnType("datetime");
        entity.Property(e => e.Locked).HasDefaultValue(false);
        entity.Property(e => e.MerchantDefinedType)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.NewCustomerFlag).HasDefaultValue(false);
        entity.Property(e => e.OrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.OriginalCurrency)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.OriginalCurrentAmount).HasColumnType("decimal(18, 2)");
        entity.Property(e => e.ParentTrans)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Pending).HasDefaultValue(false);
        entity.Property(e => e.PriceList).HasColumnType("decimal(18, 2)");
        entity.Property(e => e.ReferenceTrans)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Skulist)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SKUList");
        entity.Property(e => e.Ssamount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SSAmount");
        entity.Property(e => e.TimeOfClick)
                .HasMaxLength(15)
                .IsUnicode(false);
        entity.Property(e => e.ToolId)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.TransAmount).HasColumnType("decimal(18, 2)");
        entity.Property(e => e.TransDate).HasColumnType("datetime");
        entity.Property(e => e.TransactionType)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.UsedAcoupon)
                .HasDefaultValue(false)
                .HasColumnName("UsedACoupon");
        entity.Property(e => e.UserAgent).IsUnicode(false);
        entity.Property(e => e.Voided).HasDefaultValue(false);

        entity.HasOne(d => d.Store).WithMany(p => p.ShareAsaleData)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShareASaleData_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ShareAsaleDatum> entity);
}
