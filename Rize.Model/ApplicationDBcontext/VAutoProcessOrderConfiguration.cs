using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VAutoProcessOrderConfiguration : IEntityTypeConfiguration<VAutoProcessOrder>
{
    public void Configure(EntityTypeBuilder<VAutoProcessOrder> entity)
    {
        entity
                .HasNoKey()
                .ToView("vAutoProcessOrders");

        entity.Property(e => e.CusEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Cus__Email");
        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");
        entity.Property(e => e.OrdPlacedDate)
                .HasColumnType("datetime")
                .HasColumnName("Ord__PlacedDate");
        entity.Property(e => e.OrderNumber)
                .HasMaxLength(32)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VAutoProcessOrder> entity);
}
