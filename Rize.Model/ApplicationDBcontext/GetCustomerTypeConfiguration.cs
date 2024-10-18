using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class GetCustomerTypeConfiguration : IEntityTypeConfiguration<GetCustomerType>
{
    public void Configure(EntityTypeBuilder<GetCustomerType> entity)
    {
        entity
                .HasNoKey()
                .ToView("GetCustomerType");

        entity.Property(e => e.CusCustomerId).HasColumnName("Cus__CustomerID");
        entity.Property(e => e.IsForBusiness)
                .HasMaxLength(9)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<GetCustomerType> entity);
}
