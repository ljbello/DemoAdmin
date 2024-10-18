using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PlateCreationStatusConfiguration : IEntityTypeConfiguration<PlateCreationStatus>
{
    public void Configure(EntityTypeBuilder<PlateCreationStatus> entity)
    {
        entity.ToTable("PlateCreationStatus");

        entity.Property(e => e.PlateCreationStatusId).ValueGeneratedNever();
        entity.Property(e => e.InstanceId).HasMaxLength(255);
        entity.Property(e => e.StartTime).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PlateCreationStatus> entity);
}
