using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ImportedProductDesignMappingConfiguration : IEntityTypeConfiguration<ImportedProductDesignMapping>
{
    public void Configure(EntityTypeBuilder<ImportedProductDesignMapping> entity)
    {
        entity.HasKey(e => new { e.ProductId, e.DesignId });

        entity.ToTable("ImportedProductDesignMapping");

        entity.Property(e => e.Height).HasColumnType("decimal(10, 4)");
        entity.Property(e => e.Width).HasColumnType("decimal(10, 4)");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ImportedProductDesignMapping> entity);
}
