using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ImportedPaperStockFinishMappingConfiguration : IEntityTypeConfiguration<ImportedPaperStockFinishMapping>
{
    public void Configure(EntityTypeBuilder<ImportedPaperStockFinishMapping> entity)
    {
        entity.HasKey(e => e.ProductFacetValueId);

        entity.ToTable("ImportedPaperStockFinishMapping");

        entity.Property(e => e.ProductFacetValueId)
                .ValueGeneratedNever()
                .HasColumnName("ProductFacetValueID");
        entity.Property(e => e.LegacyName).HasMaxLength(50);
        entity.Property(e => e.PaperStockFinishId).HasColumnName("PaperStockFinishID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ImportedPaperStockFinishMapping> entity);
}
