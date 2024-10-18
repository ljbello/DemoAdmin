using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ViewOrderSummationConfiguration : IEntityTypeConfiguration<ViewOrderSummation>
{
    public void Configure(EntityTypeBuilder<ViewOrderSummation> entity)
    {
        entity
                .HasNoKey()
                .ToView("viewOrderSummation");

        entity.Property(e => e.AdjustmentAmount).HasColumnType("money");
        entity.Property(e => e.CreditAmount).HasColumnType("money");
        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");
        entity.Property(e => e.PaidAmount).HasColumnType("money");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ViewOrderSummation> entity);
}
