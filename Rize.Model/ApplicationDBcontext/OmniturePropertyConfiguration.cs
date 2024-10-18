using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OmniturePropertyConfiguration : IEntityTypeConfiguration<OmnitureProperty>
{
    public void Configure(EntityTypeBuilder<OmnitureProperty> entity)
    {
        entity.HasKey(e => new { e.OmniturePropertyTypeId, e.OmniturePropertyId });

        entity.ToTable("OmnitureProperty");

        entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.EntityCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

        entity.HasOne(d => d.OmniturePropertyType).WithMany(p => p.OmnitureProperties)
                .HasForeignKey(d => d.OmniturePropertyTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OmnitureProperty_OmniturePropertyType");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OmnitureProperty> entity);
}
