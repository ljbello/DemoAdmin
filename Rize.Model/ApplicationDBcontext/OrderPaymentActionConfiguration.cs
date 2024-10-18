using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderPaymentActionConfiguration : IEntityTypeConfiguration<OrderPaymentAction>
{
    public void Configure(EntityTypeBuilder<OrderPaymentAction> entity)
    {
        entity.HasKey(e => e.OrderPaymentActionId).HasName("PK_OrderPaymentsAction");

        entity.ToTable("OrderPaymentAction");

        entity.Property(e => e.OrderPaymentActionId).HasColumnName("OrderPaymentActionID");
        entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderPaymentAction> entity);
}
