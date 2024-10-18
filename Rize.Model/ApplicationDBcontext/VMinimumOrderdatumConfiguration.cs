using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VMinimumOrderdatumConfiguration : IEntityTypeConfiguration<VMinimumOrderdatum>
{
    public void Configure(EntityTypeBuilder<VMinimumOrderdatum> entity)
    {
        entity
                .HasNoKey()
                .ToView("vMinimumOrderdata");

        entity.Property(e => e.OrdEnteredBy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Ord__EnteredBy");
        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");
        entity.Property(e => e.OrderNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.OrdlinOrderlineid).HasColumnName("ordlin__orderlineid");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VMinimumOrderdatum> entity);
}
