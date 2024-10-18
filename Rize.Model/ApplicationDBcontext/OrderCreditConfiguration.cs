using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderCreditConfiguration : IEntityTypeConfiguration<OrderCredit>
{
    public void Configure(EntityTypeBuilder<OrderCredit> entity)
    {
        entity.HasIndex(e => e.OrderId, "OrderCredits_IX1");

        entity.Property(e => e.Amount).HasColumnType("money");
        entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        entity.Property(e => e.CustomerAccountCreditId).HasColumnName("CustomerAccountCreditID");
        entity.Property(e => e.OrderId).HasColumnName("OrderID");

        entity.HasOne(d => d.CustomerAccountCredit).WithMany(p => p.OrderCredits)
                .HasForeignKey(d => d.CustomerAccountCreditId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderCredits_CustomerAccountCredit");

        entity.HasOne(d => d.Order).WithMany(p => p.OrderCredits)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderCredits_Order");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderCredit> entity);
}
