using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ColorGroupColorConfiguration : IEntityTypeConfiguration<ColorGroupColor>
{
    public void Configure(EntityTypeBuilder<ColorGroupColor> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__ColorGro__3214EC079EF8EFE0");

        entity.ToTable("ColorGroupColor");

        entity.HasIndex(e => e.ColorName, "IX_ColorGroupColor_ColorName");

        entity.Property(e => e.ColorName)
                .HasMaxLength(50)
                .IsUnicode(false);

        entity.HasOne(d => d.ColorGroup).WithMany(p => p.ColorGroupColors)
                .HasForeignKey(d => d.ColorGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ColorGroupColor_ColorGroup");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ColorGroupColor> entity);
}
