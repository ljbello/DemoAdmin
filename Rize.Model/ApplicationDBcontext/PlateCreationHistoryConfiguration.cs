using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PlateCreationHistoryConfiguration : IEntityTypeConfiguration<PlateCreationHistory>
{
    public void Configure(EntityTypeBuilder<PlateCreationHistory> entity)
    {
        entity.ToTable("PlateCreationHistory");

        entity.Property(e => e.PlateCreationHistoryId).ValueGeneratedNever();
        entity.Property(e => e.CompletedOn).HasColumnType("datetime");
        entity.Property(e => e.InstanceId).HasMaxLength(255);
        entity.Property(e => e.StartTime).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PlateCreationHistory> entity);
}
