using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ViewOrderCustomerCreditInfoConfiguration : IEntityTypeConfiguration<ViewOrderCustomerCreditInfo>
{
    public void Configure(EntityTypeBuilder<ViewOrderCustomerCreditInfo> entity)
    {
        entity
                .HasNoKey()
                .ToView("viewOrderCustomerCreditInfo");

        entity.Property(e => e.MaxOrdersize).HasColumnType("money");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ViewOrderCustomerCreditInfo> entity);
}
