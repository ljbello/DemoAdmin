using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SaveShoppingCartReminderConfiguration : IEntityTypeConfiguration<SaveShoppingCartReminder>
{
    public void Configure(EntityTypeBuilder<SaveShoppingCartReminder> entity)
    {
        entity.ToTable("SaveShoppingCartReminder");

        entity.HasIndex(e => e.CustomerLoginId, "SaveShoppingCartReminder_IX1");

        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.OrderId).HasColumnName("OrderID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SaveShoppingCartReminder> entity);
}
