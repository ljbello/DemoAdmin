using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VAutoProcessablePreviewOrderConfiguration : IEntityTypeConfiguration<VAutoProcessablePreviewOrder>
{
    public void Configure(EntityTypeBuilder<VAutoProcessablePreviewOrder> entity)
    {
        entity
                .HasNoKey()
                .ToView("vAutoProcessablePreviewOrders");

        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderId");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VAutoProcessablePreviewOrder> entity);
}
