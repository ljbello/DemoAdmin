using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DepartmentOccasionMappingConfiguration : IEntityTypeConfiguration<DepartmentOccasionMapping>
{
    public void Configure(EntityTypeBuilder<DepartmentOccasionMapping> entity)
    {
        entity.HasKey(e => new { e.DepartmentId, e.OccasionId }).HasName("PK_DepartmentOccasionMapping_1");

        entity.ToTable("DepartmentOccasionMapping");

        entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
        entity.Property(e => e.OccasionId).HasColumnName("OccasionID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DepartmentOccasionMapping> entity);
}
