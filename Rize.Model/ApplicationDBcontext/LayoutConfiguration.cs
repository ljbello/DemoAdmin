using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class LayoutConfiguration : IEntityTypeConfiguration<Layout>
{
    public void Configure(EntityTypeBuilder<Layout> entity)
    {
        entity.ToTable("Layout");

        entity.Property(e => e.EntityCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Name).HasMaxLength(50);
        entity.Property(e => e.ProductOptionKeyId)
                .HasMaxLength(50)
                .IsUnicode(false);

        entity.HasOne(d => d.LayoutIcon).WithMany(p => p.Layouts)
                .HasForeignKey(d => d.LayoutIconId)
                .HasConstraintName("FK_Layout_LayoutIcon");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Layout> entity);
}
