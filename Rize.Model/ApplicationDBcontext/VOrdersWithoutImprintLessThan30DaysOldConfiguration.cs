using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VOrdersWithoutImprintLessThan30DaysOldConfiguration : IEntityTypeConfiguration<VOrdersWithoutImprintLessThan30DaysOld>
{
    public void Configure(EntityTypeBuilder<VOrdersWithoutImprintLessThan30DaysOld> entity)
    {
        entity
                .HasNoKey()
                .ToView("vOrdersWithoutImprintLessThan30DaysOld");

        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderId");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VOrdersWithoutImprintLessThan30DaysOld> entity);
}
