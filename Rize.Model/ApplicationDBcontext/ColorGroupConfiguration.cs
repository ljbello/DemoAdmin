using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ColorGroupConfiguration : IEntityTypeConfiguration<ColorGroup>
{
    public void Configure(EntityTypeBuilder<ColorGroup> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__ColorGro__3214EC074D74F324");

        entity.ToTable("ColorGroup");

        entity.HasIndex(e => e.FriendlyName, "IX_ColorGroup_FriendlyName");

        entity.Property(e => e.FriendlyName).HasMaxLength(50);
        entity.Property(e => e.ModifiedBy).HasDefaultValue(1);
        entity.Property(e => e.ModifiedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.ColorGroups)
                .HasForeignKey(d => d.ModifiedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Color_tblUsers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ColorGroup> entity);
}
