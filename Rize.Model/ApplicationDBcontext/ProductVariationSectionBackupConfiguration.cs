using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductVariationSectionBackupConfiguration : IEntityTypeConfiguration<ProductVariationSectionBackup>
{
    public void Configure(EntityTypeBuilder<ProductVariationSectionBackup> entity)
    {
        entity
                .HasNoKey()
                .ToTable("ProductVariation_Section_Backup");

        entity.Property(e => e.PreviewGroup)
                .HasMaxLength(30)
                .IsUnicode(false);
        entity.Property(e => e.StoreId).HasColumnName("StoreID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductVariationSectionBackup> entity);
}
