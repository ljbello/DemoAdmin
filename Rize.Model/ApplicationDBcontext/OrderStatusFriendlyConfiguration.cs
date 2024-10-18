using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderStatusFriendlyConfiguration : IEntityTypeConfiguration<OrderStatusFriendly>
{
    public void Configure(EntityTypeBuilder<OrderStatusFriendly> entity)
    {
        entity
                .HasNoKey()
                .ToTable("OrderStatusFriendly");

        entity.Property(e => e.OrderStatusFriendlyId)
                .ValueGeneratedOnAdd()
                .HasColumnName("OrderStatusFriendlyID");
        entity.Property(e => e.StatusDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.StatusDetails)
                .HasMaxLength(500)
                .IsUnicode(false);
        entity.Property(e => e.TextColor)
                .HasMaxLength(20)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderStatusFriendly> entity);
}
