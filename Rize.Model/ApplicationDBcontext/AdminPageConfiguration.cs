using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AdminPageConfiguration : IEntityTypeConfiguration<AdminPage>
{
    public void Configure(EntityTypeBuilder<AdminPage> entity)
    {
        entity.HasKey(e => e.PageId).HasName("PK_Admin_Page");

        entity.ToTable("AdminPage");

        entity.Property(e => e.PageId).HasColumnName("PageID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.DisplayName).HasMaxLength(50);
        entity.Property(e => e.Url).HasMaxLength(255);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AdminPage> entity);
}
