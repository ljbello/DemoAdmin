using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderAdjustmentConfiguration : IEntityTypeConfiguration<OrderAdjustment>
{
    public void Configure(EntityTypeBuilder<OrderAdjustment> entity)
    {
        entity.ToTable(tb => tb.HasTrigger("OrderAdjustments_UpdateDate"));

        entity.HasIndex(e => e.OrderId, "OrderAdjustments_IX1");

        entity.Property(e => e.OrderAdjustmentId).HasDefaultValueSql("(newid())");
        entity.Property(e => e.Amount).HasColumnType("money");
        entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.UpdateDate).HasColumnType("datetime");

        entity.HasOne(d => d.Order).WithMany(p => p.OrderAdjustments)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderAdjustments_Order");

        entity.HasOne(d => d.User).WithMany(p => p.OrderAdjustments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_OrderAdjustments_tblUsers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderAdjustment> entity);
}
