using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductOptionGroupExcludedPaperStockFinishConfiguration : IEntityTypeConfiguration<ProductOptionGroupExcludedPaperStockFinish>
{
    public void Configure(EntityTypeBuilder<ProductOptionGroupExcludedPaperStockFinish> entity)
    {
        entity.HasKey(e => new { e.VariationId, e.GroupEntityDescriptor, e.PaperStockFinishId });

        entity.ToTable("ProductOptionGroup_ExcludedPaperStockFinish");

        entity.Property(e => e.GroupEntityDescriptor).HasMaxLength(20);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductOptionGroupExcludedPaperStockFinish> entity);
}
