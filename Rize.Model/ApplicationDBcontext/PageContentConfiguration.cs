using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PageContentConfiguration : IEntityTypeConfiguration<PageContent>
{
    public void Configure(EntityTypeBuilder<PageContent> entity)
    {
        entity.HasKey(e => e.PageId);

        entity.ToTable("PageContent");

        entity.HasIndex(e => new { e.PageContentId, e.SiteId, e.CurrentState, e.Active }, "PageContent_IX1");

        entity.HasIndex(e => new { e.PageContentId, e.SiteId, e.MasterPageId, e.CurrentState, e.Active }, "PageContent_IX2");

        entity.HasIndex(e => new { e.PageContentId, e.SiteId, e.Active }, "index_5");

        entity.Property(e => e.PageId).HasColumnName("PageID");
        entity.Property(e => e.Content2).HasDefaultValue("");
        entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasDefaultValue(" ");
        entity.Property(e => e.H1title)
                .HasMaxLength(255)
                .HasColumnName("H1Title");
        entity.Property(e => e.MasterPageId).HasColumnName("MasterPageID");
        entity.Property(e => e.MetaDescription).HasMaxLength(500);
        entity.Property(e => e.MetaKeywords).HasMaxLength(500);
        entity.Property(e => e.MetaTitle).HasMaxLength(255);
        entity.Property(e => e.Notes)
                .IsUnicode(false)
                .HasDefaultValue("");
        entity.Property(e => e.PageContentId).HasMaxLength(255);
        entity.Property(e => e.ThemeId).HasColumnName("ThemeID");

        entity.HasOne(d => d.MasterPage).WithMany(p => p.PageContents)
                .HasForeignKey(d => d.MasterPageId)
                .HasConstraintName("FK_PageContent_PageMasterPage");

        entity.HasOne(d => d.Theme).WithMany(p => p.PageContents)
                .HasForeignKey(d => d.ThemeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PageContent_WebPageTheme");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PageContent> entity);
}
