using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CustomerPaymentMethodConfiguration : IEntityTypeConfiguration<CustomerPaymentMethod>
{
    public void Configure(EntityTypeBuilder<CustomerPaymentMethod> entity)
    {
        entity.ToTable("CustomerPaymentMethod");

        entity.HasIndex(e => e.CustomerLoginId, "CustomerPaymentMethod_IX1");

        entity.HasIndex(e => e.CorporateBillingRefId, "CustomerPaymentMethod_IX2");

        entity.Property(e => e.Id).HasColumnName("ID");
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
        entity.Property(e => e.CcexpMonth).HasColumnName("CCExpMonth");
        entity.Property(e => e.CcexpYear).HasColumnName("CCExpYear");
        entity.Property(e => e.Ccname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CCName");
        entity.Property(e => e.Ccnumber)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("CCNumber");
        entity.Property(e => e.CctypeId).HasColumnName("CCTypeID");
        entity.Property(e => e.CorporateBillingRefId).HasColumnName("CorporateBillingRefID");
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.Last4Digits)
                .HasMaxLength(4)
                .IsUnicode(false);
        entity.Property(e => e.MethodId).HasColumnName("MethodID");
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.TpgprofileId).HasColumnName("TPGProfileID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CustomerPaymentMethod> entity);
}
