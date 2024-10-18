using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VwOrdersRegularConfiguration : IEntityTypeConfiguration<VwOrdersRegular>
{
    public void Configure(EntityTypeBuilder<VwOrdersRegular> entity)
    {
        entity
                .HasNoKey()
                .ToView("vw_orders_regular");

        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VwOrdersRegular> entity);
}
