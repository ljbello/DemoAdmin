using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class NavigationMenuConfiguration : IEntityTypeConfiguration<NavigationMenu>
{
    public void Configure(EntityTypeBuilder<NavigationMenu> entity)
    {
        entity.ToTable("NavigationMenu");

        entity.HasIndex(e => e.Active, "IX_NavigationMenu_Active");

        entity.HasIndex(e => new { e.Preview, e.StoreId }, "NavigationMenu_IX1");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.BodyHtml).IsUnicode(false);
        entity.Property(e => e.CreatedBy)
                .HasMaxLength(3)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false);
        entity.Property(e => e.PublishedOn).HasColumnType("datetime");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.Styles).IsUnicode(false);
        entity.Property(e => e.TabHtml).IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<NavigationMenu> entity);
}
