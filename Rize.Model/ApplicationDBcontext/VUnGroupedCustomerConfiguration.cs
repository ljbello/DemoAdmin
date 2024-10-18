using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VUnGroupedCustomerConfiguration : IEntityTypeConfiguration<VUnGroupedCustomer>
{
    public void Configure(EntityTypeBuilder<VUnGroupedCustomer> entity)
    {
        entity
                .HasNoKey()
                .ToView("vUnGroupedCustomers");

        entity.Property(e => e.CusCustomerId).HasColumnName("Cus__CustomerID");
        entity.Property(e => e.CusDateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Cus__DateCreated");
        entity.Property(e => e.CusEmail)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Cus__Email");
        entity.Property(e => e.CusFirstName)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Cus__FirstName");
        entity.Property(e => e.CusLastName)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Cus__LastName");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VUnGroupedCustomer> entity);
}
