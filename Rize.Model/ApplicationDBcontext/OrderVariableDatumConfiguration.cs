using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderVariableDatumConfiguration : IEntityTypeConfiguration<OrderVariableDatum>
{
    public void Configure(EntityTypeBuilder<OrderVariableDatum> entity)
    {
        entity.HasNoKey();

        entity.Property(e => e.Address1)
                .HasMaxLength(75)
                .IsUnicode(false);
        entity.Property(e => e.Address2)
                .HasMaxLength(75)
                .IsUnicode(false);
        entity.Property(e => e.Address3)
                .HasMaxLength(75)
                .IsUnicode(false);
        entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Name)
                .HasMaxLength(75)
                .IsUnicode(false);
        entity.Property(e => e.OrderId).HasColumnName("OrderID");
        entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");
        entity.Property(e => e.State)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.Zip)
                .HasMaxLength(12)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderVariableDatum> entity);
}
