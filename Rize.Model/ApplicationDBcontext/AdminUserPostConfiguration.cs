using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AdminUserPostConfiguration : IEntityTypeConfiguration<AdminUserPost>
{
    public void Configure(EntityTypeBuilder<AdminUserPost> entity)
    {
        entity.HasKey(e => e.PostId);

        entity.ToTable("AdminUserPost");

        entity.HasIndex(e => new { e.CreatedBy, e.CreatedOn }, "AdminUserPost_IX1");

        entity.Property(e => e.PostId).HasColumnName("PostID");
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.PublishedOn).HasColumnType("datetime");
        entity.Property(e => e.Title).HasMaxLength(150);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AdminUserPost> entity);
}
