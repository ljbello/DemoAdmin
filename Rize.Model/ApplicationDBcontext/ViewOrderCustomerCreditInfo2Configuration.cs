using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ViewOrderCustomerCreditInfo2Configuration : IEntityTypeConfiguration<ViewOrderCustomerCreditInfo2>
{
    public void Configure(EntityTypeBuilder<ViewOrderCustomerCreditInfo2> entity)
    {
        entity
                .HasNoKey()
                .ToView("viewOrderCustomerCreditInfo2");

        entity.Property(e => e.MaxOrdersize).HasColumnType("money");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ViewOrderCustomerCreditInfo2> entity);
}
