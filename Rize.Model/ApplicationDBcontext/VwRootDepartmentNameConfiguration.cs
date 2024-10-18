using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VwRootDepartmentNameConfiguration : IEntityTypeConfiguration<VwRootDepartmentName>
{
    public void Configure(EntityTypeBuilder<VwRootDepartmentName> entity)
    {
        entity
                .HasNoKey()
                .ToView("vw_Root_Department_Names");

        entity.Property(e => e.Department)
                .HasMaxLength(100)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VwRootDepartmentName> entity);
}
