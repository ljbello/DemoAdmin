using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderLineCreditConfiguration : IEntityTypeConfiguration<OrderLineCredit>
{
    public void Configure(EntityTypeBuilder<OrderLineCredit> entity)
    {
        entity.Property(e => e.Amount).HasColumnType("money");
        entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        entity.Property(e => e.CustomerAccountCreditId).HasColumnName("CustomerAccountCreditID");
        entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");

        entity.HasOne(d => d.CustomerAccountCredit).WithMany(p => p.OrderLineCredits)
                .HasForeignKey(d => d.CustomerAccountCreditId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderLineCredits_CustomerAccountCredit");

        entity.HasOne(d => d.OrderLine).WithMany(p => p.OrderLineCredits)
                .HasForeignKey(d => d.OrderLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderLineCredits_tblOrderLines");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderLineCredit> entity);
}
