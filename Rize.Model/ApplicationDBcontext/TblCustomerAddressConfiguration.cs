using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCustomerAddressConfiguration : IEntityTypeConfiguration<TblCustomerAddress>
{
    public void Configure(EntityTypeBuilder<TblCustomerAddress> entity)
    {
        entity.HasKey(e => e.CusAddCustomerAddressId).HasName("tblCustomerAddresses_PK");

        entity.ToTable("tblCustomerAddresses", tb => tb.HasTrigger("trigger_tblCustomerAddresses_Insert_Update"));

        entity.HasIndex(e => e.CusAddCleanPhone, "IDX_CleanPhone");

        entity.HasIndex(e => e.CusCustomerId, "IDX_CustmomerAddress_CustomerID");

        entity.HasIndex(e => new { e.CusAddAddress1, e.CusAddAddress2, e.CusAddCity, e.StaStateId, e.CusAddZip }, "IDX_CustomerAddress_Address");

        entity.HasIndex(e => new { e.CusAddCustomerAddressId, e.StaStateId }, "tblCustomerAddresses_IX1");

        entity.HasIndex(e => new { e.CusCustomerId, e.CusAddCompany, e.CusAddAddress1, e.CusAddAddress2, e.CusAddPhone }, "tblCustomerAddresses_IX2");

        entity.HasIndex(e => new { e.CusAddCustomerAddressId, e.CusAddName, e.CusAddCompany, e.StaStateId }, "tblCustomerAddresses_IX3");

        entity.HasIndex(e => e.CusAddCompany, "tblCustomerAddresses_IX4");

        entity.HasIndex(e => e.CusAddCustomerAddressId, "tblCustomerAddresses_IX5");

        entity.HasIndex(e => e.CusCustomerId, "tblCustomerAddresses_IX6");

        entity.HasIndex(e => e.CusAddIsShippingAddress, "tblCustomerAddresses_IX7");

        entity.Property(e => e.CusAddCustomerAddressId).HasColumnName("CusAdd__CustomerAddressID");
        entity.Property(e => e.CouCountryId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("USA")
                .IsFixedLength()
                .HasColumnName("Cou__CountryID");
        entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.CusAddAddress1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CusAdd__Address1");
        entity.Property(e => e.CusAddAddress2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CusAdd__Address2");
        entity.Property(e => e.CusAddCity)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("CusAdd__City");
        entity.Property(e => e.CusAddCleanPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CusAdd__CleanPhone");
        entity.Property(e => e.CusAddCompany)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("CusAdd__Company");
        entity.Property(e => e.CusAddContactTitle)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CusAdd__ContactTitle");
        entity.Property(e => e.CusAddEveningPhone)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("CusAdd__EveningPhone");
        entity.Property(e => e.CusAddFax)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("CusAdd__Fax");
        entity.Property(e => e.CusAddIsShippingAddress).HasColumnName("CusAdd__IsShippingAddress");
        entity.Property(e => e.CusAddLastName)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("CusAdd__LastName");
        entity.Property(e => e.CusAddName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CusAdd__Name");
        entity.Property(e => e.CusAddPhone)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("CusAdd__Phone");
        entity.Property(e => e.CusAddZip)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CusAdd__Zip");
        entity.Property(e => e.CusCustomerId).HasColumnName("Cus__CustomerID");
        entity.Property(e => e.StaStateId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Sta__StateID");
        entity.Property(e => e.UpdateDate).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCustomerAddress> entity);
}
