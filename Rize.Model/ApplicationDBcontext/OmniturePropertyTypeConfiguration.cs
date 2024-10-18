using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OmniturePropertyTypeConfiguration : IEntityTypeConfiguration<OmniturePropertyType>
{
    public void Configure(EntityTypeBuilder<OmniturePropertyType> entity)
    {
        entity.ToTable("OmniturePropertyType");

        entity.Property(e => e.OmniturePropertyTypeId).ValueGeneratedNever();
        entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.EntityCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OmniturePropertyType> entity);
}
