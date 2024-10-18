using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ThemeConfiguration : IEntityTypeConfiguration<Theme>
{
    public void Configure(EntityTypeBuilder<Theme> entity)
    {
        entity.ToTable("Theme");

        entity.HasIndex(e => e.ThemeName, "Theme_IX1");

        entity.Property(e => e.ThemeId).HasColumnName("ThemeID");
        entity.Property(e => e.Active).HasDefaultValue(true);
        entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ParentThemeId).HasColumnName("ParentThemeID");
        entity.Property(e => e.ThemeName)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Theme> entity);
}
