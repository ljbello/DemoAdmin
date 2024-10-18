using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SiteMapConfiguration : IEntityTypeConfiguration<SiteMap>
{
    public void Configure(EntityTypeBuilder<SiteMap> entity)
    {
        entity.ToTable("SiteMap");

        entity.HasIndex(e => e.SiteMapName, "IX_SiteMap")
                .IsUnique()
                .IsDescending();

        entity.HasIndex(e => e.DepartmentId, "IX_SiteMap_1").IsUnique();

        entity.Property(e => e.Description).IsUnicode(false);
        entity.Property(e => e.H1title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("H1Title");
        entity.Property(e => e.MasterPageId).HasColumnName("MasterPageID");
        entity.Property(e => e.MetaDescription).HasMaxLength(500);
        entity.Property(e => e.MetaKeywords).HasMaxLength(500);
        entity.Property(e => e.MetaTitle)
                .HasMaxLength(255)
                .IsUnicode(false);
        entity.Property(e => e.SiteMapName)
                .HasMaxLength(255)
                .IsUnicode(false);
        entity.Property(e => e.ThemeId).HasColumnName("ThemeID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SiteMap> entity);
}
