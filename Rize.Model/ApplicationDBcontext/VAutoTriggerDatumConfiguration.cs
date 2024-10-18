using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VAutoTriggerDatumConfiguration : IEntityTypeConfiguration<VAutoTriggerDatum>
{
    public void Configure(EntityTypeBuilder<VAutoTriggerDatum> entity)
    {
        entity
                .HasNoKey()
                .ToView("vAutoTriggerData");

        entity.Property(e => e.AdjustmentAmount).HasColumnType("money");
        entity.Property(e => e.BillingAddress)
                .HasMaxLength(64)
                .IsUnicode(false);
        entity.Property(e => e.BillingState)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        entity.Property(e => e.BillingZip)
                .HasMaxLength(12)
                .IsUnicode(false);
        entity.Property(e => e.ContactEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.ContactFirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ContactLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.CreditAmount).HasColumnType("money");
        entity.Property(e => e.DisTypDiscountTypeId).HasColumnName("DisTyp__DiscountTypeID");
        entity.Property(e => e.OrderId).HasColumnName("OrderID");
        entity.Property(e => e.PaperType)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        entity.Property(e => e.ProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.ProductType)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
        entity.Property(e => e.PromoCode)
                .HasMaxLength(16)
                .IsUnicode(false);
        entity.Property(e => e.PromoType)
                .HasMaxLength(64)
                .IsUnicode(false);
        entity.Property(e => e.SettlementAmount).HasColumnType("money");
        entity.Property(e => e.ShiMetShippingMethodId).HasColumnName("ShiMet__ShippingMethodID");
        entity.Property(e => e.ShipMethod)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.ShippingAddress)
                .HasMaxLength(64)
                .IsUnicode(false);
        entity.Property(e => e.ShippingCompany)
                .HasMaxLength(128)
                .IsUnicode(false);
        entity.Property(e => e.ShippingState)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        entity.Property(e => e.ShippingZip)
                .HasMaxLength(12)
                .IsUnicode(false);
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
        entity.Property(e => e.VariationName)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VAutoTriggerDatum> entity);
}
