using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class StoreShippingGlobalRateConfiguration : IEntityTypeConfiguration<StoreShippingGlobalRate>
{
    public void Configure(EntityTypeBuilder<StoreShippingGlobalRate> entity)
    {
        entity.ToTable("StoreShippingGlobalRate");

        entity.HasIndex(e => new { e.ShippingMethodId, e.StoreId, e.Type, e.Low, e.High, e.Active, e.CreatedOn }, "StoreShippingGlobalRate_IX1");

        entity.Property(e => e.Active).HasDefaultValue(true);
        entity.Property(e => e.CreatedBy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.FlatRate).HasColumnType("money");
        entity.Property(e => e.High).HasColumnType("decimal(18, 2)");
        entity.Property(e => e.Low).HasColumnType("decimal(18, 2)");
        entity.Property(e => e.ModifiedBy).HasDefaultValue(1);
        entity.Property(e => e.ModifiedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Multiplier).HasDefaultValue(true);
        entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<StoreShippingGlobalRate> entity);
}
