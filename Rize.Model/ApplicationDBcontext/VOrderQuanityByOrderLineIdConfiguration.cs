using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VOrderQuanityByOrderLineIdConfiguration : IEntityTypeConfiguration<VOrderQuanityByOrderLineId>
{
    public void Configure(EntityTypeBuilder<VOrderQuanityByOrderLineId> entity)
    {
        entity
                .HasNoKey()
                .ToView("vOrderQuanityByOrderLineID");

        entity.Property(e => e.OrdLinOrderLineId).HasColumnName("OrdLin__OrderLineID");
        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VOrderQuanityByOrderLineId> entity);
}
