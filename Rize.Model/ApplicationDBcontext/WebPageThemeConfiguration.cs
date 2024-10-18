using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class WebPageThemeConfiguration : IEntityTypeConfiguration<WebPageTheme>
{
    public void Configure(EntityTypeBuilder<WebPageTheme> entity)
    {
        entity.HasKey(e => e.ThemeId);

        entity.ToTable("WebPageTheme");

        entity.Property(e => e.ThemeId).HasColumnName("ThemeID");
        entity.Property(e => e.SiteId)
                .HasDefaultValue(1)
                .HasColumnName("SiteID");
        entity.Property(e => e.ThemeName)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<WebPageTheme> entity);
}
