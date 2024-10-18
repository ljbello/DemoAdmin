using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TaxorderConfiguration : IEntityTypeConfiguration<Taxorder>
{
    public void Configure(EntityTypeBuilder<Taxorder> entity)
    {
        entity
                .HasNoKey()
                .ToTable("taxorders");

        entity.Property(e => e.OrderId).HasColumnName("OrderID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Taxorder> entity);
}
