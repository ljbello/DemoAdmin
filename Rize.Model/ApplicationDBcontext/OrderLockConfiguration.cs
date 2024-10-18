using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderLockConfiguration : IEntityTypeConfiguration<OrderLock>
{
    public void Configure(EntityTypeBuilder<OrderLock> entity)
    {
        entity.HasKey(e => e.OrderId).HasName("PK_OrderLocks_1");

        entity.Property(e => e.OrderId).ValueGeneratedNever();
        entity.Property(e => e.LastRefresh).HasColumnType("datetime");
        entity.Property(e => e.LockDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderLock> entity);
}
