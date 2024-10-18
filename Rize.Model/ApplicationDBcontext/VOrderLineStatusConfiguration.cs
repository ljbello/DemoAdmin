using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VOrderLineStatusConfiguration : IEntityTypeConfiguration<VOrderLineStatus>
{
    public void Configure(EntityTypeBuilder<VOrderLineStatus> entity)
    {
        entity
                .HasNoKey()
                .ToView("vOrderLineStatus");

        entity.Property(e => e.CreationDate).HasColumnType("datetime");
        entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
        entity.Property(e => e.Notes).IsUnicode(false);
        entity.Property(e => e.OrdStaDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("OrdSta__Description");
        entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");
        entity.Property(e => e.OrderNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");
        entity.Property(e => e.RunDate).HasColumnType("datetime");
        entity.Property(e => e.ShiMetStrDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("ShiMet__strDescription");
        entity.Property(e => e.ShippingDate).HasColumnType("datetime");
        entity.Property(e => e.SupName)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("Sup__Name");
        entity.Property(e => e.TrackingNumber)
                .HasMaxLength(3000)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VOrderLineStatus> entity);
}
