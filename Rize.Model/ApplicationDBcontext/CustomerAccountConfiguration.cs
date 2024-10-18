using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CustomerAccountConfiguration : IEntityTypeConfiguration<CustomerAccount>
{
    public void Configure(EntityTypeBuilder<CustomerAccount> entity)
    {
        entity.ToTable("CustomerAccount");

        entity.HasIndex(e => e.ContactEmailAddress, "CustomerAccount_IX1");

        entity.HasIndex(e => e.CustomerLoginId, "IX_CustomerAccount_CustomerLoginId").IsUnique();

        entity.Property(e => e.CustomerAccountId).HasDefaultValueSql("(newid())");
        entity.Property(e => e.BillingAddressLine1)
                .HasMaxLength(75)
                .IsUnicode(false);
        entity.Property(e => e.BillingAddressLine2)
                .HasMaxLength(75)
                .IsUnicode(false);
        entity.Property(e => e.BillingCity)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.BillingCompany)
                .HasMaxLength(150)
                .IsUnicode(false);
        entity.Property(e => e.BillingCountryId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BillingCountryID");
        entity.Property(e => e.BillingFirstName)
                .HasMaxLength(75)
                .IsUnicode(false);
        entity.Property(e => e.BillingLastName)
                .HasMaxLength(75)
                .IsUnicode(false);
        entity.Property(e => e.BillingPhoneNumber)
                .HasMaxLength(25)
                .IsUnicode(false);
        entity.Property(e => e.BillingState)
                .HasMaxLength(2)
                .IsUnicode(false);
        entity.Property(e => e.BillingZipCode)
                .HasMaxLength(12)
                .IsUnicode(false);
        entity.Property(e => e.ContactEmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.ContactLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ContactPhone)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.CreditLimit).HasColumnType("money");
        entity.Property(e => e.ShippingAddressLine1)
                .HasMaxLength(75)
                .IsUnicode(false);
        entity.Property(e => e.ShippingAddressLine2)
                .HasMaxLength(75)
                .IsUnicode(false);
        entity.Property(e => e.ShippingCity)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ShippingCompany)
                .HasMaxLength(150)
                .IsUnicode(false);
        entity.Property(e => e.ShippingCountryId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ShippingCountryID");
        entity.Property(e => e.ShippingFirstName)
                .HasMaxLength(75)
                .IsUnicode(false);
        entity.Property(e => e.ShippingLastName)
                .HasMaxLength(75)
                .IsUnicode(false);
        entity.Property(e => e.ShippingPhoneNumber)
                .HasMaxLength(25)
                .IsUnicode(false);
        entity.Property(e => e.ShippingState)
                .HasMaxLength(2)
                .IsUnicode(false);
        entity.Property(e => e.ShippingZipCode)
                .HasMaxLength(12)
                .IsUnicode(false);
        entity.Property(e => e.TaxExemptFileExtension)
                .HasMaxLength(6)
                .IsUnicode(false);
        entity.Property(e => e.TaxExemptUploadDate).HasColumnType("datetime");

        entity.HasOne(d => d.CustomerLogin).WithOne(p => p.CustomerAccount)
                .HasForeignKey<CustomerAccount>(d => d.CustomerLoginId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerAccount_CustomerLogins");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CustomerAccount> entity);
}
