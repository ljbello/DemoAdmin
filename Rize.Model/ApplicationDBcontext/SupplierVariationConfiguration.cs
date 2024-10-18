using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierVariationConfiguration : IEntityTypeConfiguration<SupplierVariation>
{
    public void Configure(EntityTypeBuilder<SupplierVariation> entity)
    {
        entity.ToTable("SupplierVariation");

        entity.Property(e => e.CreatedBy).HasDefaultValue(1);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierVariation> entity);
}
