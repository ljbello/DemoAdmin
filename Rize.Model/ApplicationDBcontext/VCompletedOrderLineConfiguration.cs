using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VCompletedOrderLineConfiguration : IEntityTypeConfiguration<VCompletedOrderLine>
{
    public void Configure(EntityTypeBuilder<VCompletedOrderLine> entity)
    {
        entity
                .HasNoKey()
                .ToView("vCompletedOrderLines");

        entity.Property(e => e.OrdLinQuantity).HasColumnName("OrdLin__Quantity");
        entity.Property(e => e.OrdLinReferenceProductId).HasColumnName("OrdLin__ReferenceProductID");
        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");
        entity.Property(e => e.OrdPlacedDate)
                .HasColumnType("datetime")
                .HasColumnName("Ord__PlacedDate");
        entity.Property(e => e.OrdStaOrderStatusId).HasColumnName("OrdSta__OrderStatusID");
        entity.Property(e => e.ParOrderPartId).HasColumnName("Par__OrderPartID");
        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VCompletedOrderLine> entity);
}
