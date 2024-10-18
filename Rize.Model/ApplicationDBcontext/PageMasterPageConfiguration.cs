using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PageMasterPageConfiguration : IEntityTypeConfiguration<PageMasterPage>
{
    public void Configure(EntityTypeBuilder<PageMasterPage> entity)
    {
        entity.HasKey(e => e.MasterPageId);

        entity.ToTable("PageMasterPage");

        entity.Property(e => e.MasterPageId).HasColumnName("MasterPageID");
        entity.Property(e => e.MasterPageName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.SiteId).HasColumnName("SiteID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PageMasterPage> entity);
}
