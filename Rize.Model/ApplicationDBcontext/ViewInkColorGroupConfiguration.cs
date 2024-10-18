using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ViewInkColorGroupConfiguration : IEntityTypeConfiguration<ViewInkColorGroup>
{
    public void Configure(EntityTypeBuilder<ViewInkColorGroup> entity)
    {
        entity
                .HasNoKey()
                .ToView("viewInkColorGroup");

        entity.Property(e => e.Icsmcolor)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ICSMColor");
        entity.Property(e => e.InkColorId).HasColumnName("InkColorID");
        entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.Pmscode)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PMSCode");
        entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
        entity.Property(e => e.Rgb)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("RGB");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ViewInkColorGroup> entity);
}
