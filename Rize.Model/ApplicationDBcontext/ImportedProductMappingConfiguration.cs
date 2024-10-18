using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ImportedProductMappingConfiguration : IEntityTypeConfiguration<ImportedProductMapping>
{
    public void Configure(EntityTypeBuilder<ImportedProductMapping> entity)
    {
        entity
                .HasNoKey()
                .ToTable("ImportedProductMapping");

        entity.Property(e => e.ProductNumber).HasMaxLength(255);
        entity.Property(e => e.ThemeId).HasColumnName("ThemeID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ImportedProductMapping> entity);
}
