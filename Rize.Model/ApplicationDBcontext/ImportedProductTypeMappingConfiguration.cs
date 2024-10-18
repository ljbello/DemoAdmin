using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ImportedProductTypeMappingConfiguration : IEntityTypeConfiguration<ImportedProductTypeMapping>
{
    public void Configure(EntityTypeBuilder<ImportedProductTypeMapping> entity)
    {
        entity
                .HasNoKey()
                .ToTable("ImportedProductTypeMapping");

        entity.Property(e => e.OldProductName).HasMaxLength(255);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ImportedProductTypeMapping> entity);
}
