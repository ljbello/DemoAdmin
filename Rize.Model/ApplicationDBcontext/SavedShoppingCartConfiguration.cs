using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SavedShoppingCartConfiguration : IEntityTypeConfiguration<SavedShoppingCart>
{
    public void Configure(EntityTypeBuilder<SavedShoppingCart> entity)
    {
        entity.HasIndex(e => e.CustomerLoginId, "IX_SavedShoppingCarts_CustomerLoginId");

        entity.HasIndex(e => e.OrderId, "IX_SavedShoppingCarts_OrderId");

        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

        entity.HasOne(d => d.Order).WithMany(p => p.SavedShoppingCarts)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SavedShoppingCarts_Order");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SavedShoppingCart> entity);
}
