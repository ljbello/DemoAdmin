using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OccasionConfiguration : IEntityTypeConfiguration<Occasion>
{
    public void Configure(EntityTypeBuilder<Occasion> entity)
    {
        entity.ToTable("Occasion");

        entity.HasIndex(e => e.OccasionName, "Occasion_IX1").IsUnique();

        entity.Property(e => e.OccasionId).HasColumnName("OccasionID");
        entity.Property(e => e.Active).HasDefaultValue(true);
        entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.OccasionName)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Occasion> entity);
}
