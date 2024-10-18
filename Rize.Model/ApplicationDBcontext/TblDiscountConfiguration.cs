using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblDiscountConfiguration : IEntityTypeConfiguration<TblDiscount>
{
    public void Configure(EntityTypeBuilder<TblDiscount> entity)
    {
        entity.HasKey(e => e.DisDiscountId).HasName("tblDiscounts_PK");

        entity.ToTable("tblDiscounts");

        entity.HasIndex(e => e.DisExpirationDate, "IX_tblDiscounts_IX1");

        entity.HasIndex(e => new { e.DisTypDiscountTypeId, e.StoStoreId }, "tblDiscounts_IX2");

        entity.Property(e => e.DisDiscountId).HasColumnName("Dis__DiscountID");
        entity.Property(e => e.CouDisLumpSumDiscount)
                .HasColumnType("money")
                .HasColumnName("CouDis__LumpSumDiscount");
        entity.Property(e => e.CouDisPercentageDiscount)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("CouDis__PercentageDiscount");
        entity.Property(e => e.CouDisQuantityLowerLimit).HasColumnName("CouDis__QuantityLowerLimit");
        entity.Property(e => e.CouDisQuantityUpperLimit).HasColumnName("CouDis__QuantityUpperLimit");
        entity.Property(e => e.CouDisTotalLowerLimit)
                .HasColumnType("money")
                .HasColumnName("CouDis__TotalLowerLimit");
        entity.Property(e => e.CouDisTotalUpperLimit)
                .HasColumnType("money")
                .HasColumnName("CouDis__TotalUpperLimit");
        entity.Property(e => e.CreditAmount).HasColumnType("money");
        entity.Property(e => e.CreditCategoryId).HasColumnName("CreditCategoryID");
        entity.Property(e => e.CreditName)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.DisExpirationDate)
                .HasColumnType("datetime")
                .HasColumnName("Dis__ExpirationDate");
        entity.Property(e => e.DisName)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Dis__Name");
        entity.Property(e => e.DisShortDescription)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Dis__ShortDescription");
        entity.Property(e => e.DisTypDiscountTypeId).HasColumnName("DisTyp__DiscountTypeID");
        entity.Property(e => e.DiscountByCategoryId).HasColumnName("DiscountByCategoryID");
        entity.Property(e => e.Reason)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ReasonDetail)
                .HasMaxLength(128)
                .IsUnicode(false);
        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");

        entity.HasOne(d => d.DisTypDiscountType).WithMany(p => p.TblDiscounts)
                .HasForeignKey(d => d.DisTypDiscountTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblDiscountTypes_tblDiscounts_FK1");

        entity.HasOne(d => d.StoStore).WithMany(p => p.TblDiscounts)
                .HasForeignKey(d => d.StoStoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDiscounts_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblDiscount> entity);
}
