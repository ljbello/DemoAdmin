using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PageAreaContentConfiguration : IEntityTypeConfiguration<PageAreaContent>
{
    public void Configure(EntityTypeBuilder<PageAreaContent> entity)
    {
        entity.HasKey(e => new { e.Id, e.ContentType, e.PageContentId, e.SiteId, e.Area });

        entity.ToTable("PageAreaContent");

        entity.HasIndex(e => new { e.Area, e.SiteId, e.PageContentId, e.ContentType, e.CurrentState }, "PageAreaContent_IX1");

        entity.Property(e => e.Id).ValueGeneratedOnAdd();
        entity.Property(e => e.ContentType).HasDefaultValue(1);
        entity.Property(e => e.PageContentId)
                .HasMaxLength(255)
                .IsUnicode(false);
        entity.Property(e => e.Area)
                .HasMaxLength(255)
                .IsUnicode(false);
        entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PageAreaContent> entity);
}
