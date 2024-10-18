using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VOrdersWithAllNonPreviewOrderLineConfiguration : IEntityTypeConfiguration<VOrdersWithAllNonPreviewOrderLine>
{
    public void Configure(EntityTypeBuilder<VOrdersWithAllNonPreviewOrderLine> entity)
    {
        entity
                .HasNoKey()
                .ToView("vOrdersWithAllNonPreviewOrderLines");

        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderId");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VOrdersWithAllNonPreviewOrderLine> entity);
}
