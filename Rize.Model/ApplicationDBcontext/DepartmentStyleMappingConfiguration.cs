using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DepartmentStyleMappingConfiguration : IEntityTypeConfiguration<DepartmentStyleMapping>
{
    public void Configure(EntityTypeBuilder<DepartmentStyleMapping> entity)
    {
        entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__B2079BCD00B92F6E");

        entity.ToTable("DepartmentStyleMapping");

        entity.Property(e => e.DepartmentId)
                .ValueGeneratedNever()
                .HasColumnName("DepartmentID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DepartmentStyleMapping> entity);
}
