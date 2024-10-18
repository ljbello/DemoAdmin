using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class StoreShippingMethodConfiguration : IEntityTypeConfiguration<StoreShippingMethod>
{
    public void Configure(EntityTypeBuilder<StoreShippingMethod> entity)
    {
        entity.ToTable("StoreShippingMethod");

        entity.HasOne(d => d.ShippingMethod).WithMany(p => p.StoreShippingMethods)
                .HasForeignKey(d => d.ShippingMethodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StoreShippingMethod_tblShippingMethods");

        entity.HasOne(d => d.Store).WithMany(p => p.StoreShippingMethods)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StoreShippingMethod_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<StoreShippingMethod> entity);
}
