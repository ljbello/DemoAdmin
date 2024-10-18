using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DepartmentProductTypeMappingConfiguration : IEntityTypeConfiguration<DepartmentProductTypeMapping>
{
    public void Configure(EntityTypeBuilder<DepartmentProductTypeMapping> entity)
    {
        entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__B2079BED13F48BF5");

        entity.ToTable("DepartmentProductTypeMapping");

        entity.Property(e => e.DepartmentId).ValueGeneratedNever();

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DepartmentProductTypeMapping> entity);
}
