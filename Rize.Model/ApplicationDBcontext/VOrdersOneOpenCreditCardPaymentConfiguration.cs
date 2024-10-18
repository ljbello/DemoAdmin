using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VOrdersOneOpenCreditCardPaymentConfiguration : IEntityTypeConfiguration<VOrdersOneOpenCreditCardPayment>
{
    public void Configure(EntityTypeBuilder<VOrdersOneOpenCreditCardPayment> entity)
    {
        entity
                .HasNoKey()
                .ToView("vOrdersOneOpenCreditCardPayment");

        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderId");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VOrdersOneOpenCreditCardPayment> entity);
}
