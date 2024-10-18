using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PageNavigationLinkConfiguration : IEntityTypeConfiguration<PageNavigationLink>
{
    public void Configure(EntityTypeBuilder<PageNavigationLink> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK_NavagationLinks");

        entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
        entity.Property(e => e.DepartmentId).HasDefaultValue(1);
        entity.Property(e => e.Link)
                .HasMaxLength(250)
                .IsUnicode(false);
        entity.Property(e => e.Text)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.Visible).HasDefaultValue(true);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PageNavigationLink> entity);
}
