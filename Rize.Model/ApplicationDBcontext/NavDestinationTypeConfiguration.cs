using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class NavDestinationTypeConfiguration : IEntityTypeConfiguration<NavDestinationType>
{
    public void Configure(EntityTypeBuilder<NavDestinationType> entity)
    {
        entity.ToTable("NavDestinationType");

        entity.Property(e => e.NavDestinationTypeId).HasColumnName("NavDestinationTypeID");
        entity.Property(e => e.DestinationTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<NavDestinationType> entity);
}
