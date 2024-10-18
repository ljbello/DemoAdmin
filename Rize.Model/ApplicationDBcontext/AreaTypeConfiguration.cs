using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AreaTypeConfiguration : IEntityTypeConfiguration<AreaType>
{
    public void Configure(EntityTypeBuilder<AreaType> entity)
    {
        entity.ToTable("AreaType");

        entity.Property(e => e.AreaTypeId).ValueGeneratedNever();
        entity.Property(e => e.EntityCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AreaType> entity);
}
