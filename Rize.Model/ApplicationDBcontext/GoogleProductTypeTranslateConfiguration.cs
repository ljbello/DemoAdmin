using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class GoogleProductTypeTranslateConfiguration : IEntityTypeConfiguration<GoogleProductTypeTranslate>
{
    public void Configure(EntityTypeBuilder<GoogleProductTypeTranslate> entity)
    {
        entity
                .HasNoKey()
                .ToTable("GoogleProductTypeTranslate");

        entity.Property(e => e.GoogleId).HasColumnName("GoogleID");
        entity.Property(e => e.ProductType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("product_type");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<GoogleProductTypeTranslate> entity);
}
