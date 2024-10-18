using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class Pv4browserConfiguration : IEntityTypeConfiguration<Pv4browser>
{
    public void Configure(EntityTypeBuilder<Pv4browser> entity)
    {
        entity.ToTable("PV4Browsers");

        entity.HasIndex(e => new { e.Browser, e.Enabled }, "IX_PV4Browsers_BrowserName_Enabled").IsUnique();

        entity.Property(e => e.Browser)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.CompatibleDevice).HasMaxLength(200);
        entity.Property(e => e.Enabled).HasDefaultValue(true);
        entity.Property(e => e.MinimumVersion)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.UserAgent).HasMaxLength(256);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Pv4browser> entity);
}
