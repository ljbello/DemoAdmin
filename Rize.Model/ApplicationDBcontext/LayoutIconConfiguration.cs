using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class LayoutIconConfiguration : IEntityTypeConfiguration<LayoutIcon>
{
    public void Configure(EntityTypeBuilder<LayoutIcon> entity)
    {
        entity.ToTable("LayoutIcon");

        entity.Property(e => e.LayoutIconId).ValueGeneratedNever();
        entity.Property(e => e.EntityCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ImageName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.LayoutName)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<LayoutIcon> entity);
}
