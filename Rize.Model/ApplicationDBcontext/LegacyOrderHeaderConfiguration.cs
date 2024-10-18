using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class LegacyOrderHeaderConfiguration : IEntityTypeConfiguration<LegacyOrderHeader>
{
    public void Configure(EntityTypeBuilder<LegacyOrderHeader> entity)
    {
        entity.HasKey(e => e.OrderNumber);

        entity.ToTable("LegacyOrderHeader");

        entity.HasIndex(e => new { e.Email, e.StoreId }, "LegacyOrderHeader_IX1");

        entity.HasIndex(e => e.CustomerLoginId, "LegacyOrderHeader_IX2");

        entity.HasIndex(e => e.CompanyName, "LegacyOrderHeader_IX3");

        entity.Property(e => e.OrderNumber).ValueGeneratedNever();
        entity.Property(e => e.AnsweredAs)
                .HasMaxLength(25)
                .IsUnicode(false);
        entity.Property(e => e.BillAddr1)
                .HasMaxLength(35)
                .IsUnicode(false);
        entity.Property(e => e.BillAddr2)
                .HasMaxLength(35)
                .IsUnicode(false);
        entity.Property(e => e.BillAddrCity)
                .HasMaxLength(35)
                .IsUnicode(false);
        entity.Property(e => e.BillAddrState)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        entity.Property(e => e.BillAddrZip)
                .HasMaxLength(12)
                .IsUnicode(false);
        entity.Property(e => e.CompanyName)
                .HasMaxLength(70)
                .IsUnicode(false);
        entity.Property(e => e.ConfirmationNumber)
                .HasMaxLength(35)
                .IsUnicode(false);
        entity.Property(e => e.CreateDate).HasColumnType("datetime");
        entity.Property(e => e.CustomerLoginId).HasColumnName("CustomerLoginID");
        entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Merchandise).HasColumnType("money");
        entity.Property(e => e.Name)
                .HasMaxLength(62)
                .IsUnicode(false);
        entity.Property(e => e.OrderStatus)
                .HasMaxLength(30)
                .IsUnicode(false);
        entity.Property(e => e.OrderStatusCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        entity.Property(e => e.Phone)
                .HasMaxLength(12)
                .IsUnicode(false);
        entity.Property(e => e.Ponumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PONumber");
        entity.Property(e => e.PromoCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.Shipping).HasColumnType("money");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.Tax).HasColumnType("money");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<LegacyOrderHeader> entity);
}
