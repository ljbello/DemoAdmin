using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AreaNameConfiguration : IEntityTypeConfiguration<AreaName>
{
    public void Configure(EntityTypeBuilder<AreaName> entity)
    {
        entity.ToTable("AreaName");

        entity.Property(e => e.AreaNameId).HasColumnName("AreaNameID");
        entity.Property(e => e.AreaName1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AreaName");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AreaName> entity);
}
