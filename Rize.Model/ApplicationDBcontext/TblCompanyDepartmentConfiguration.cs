using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCompanyDepartmentConfiguration : IEntityTypeConfiguration<TblCompanyDepartment>
{
    public void Configure(EntityTypeBuilder<TblCompanyDepartment> entity)
    {
        entity.HasKey(e => e.ComDepCompanyDepartmentId);

        entity.ToTable("tblCompanyDepartments");

        entity.Property(e => e.ComDepCompanyDepartmentId)
                .ValueGeneratedNever()
                .HasColumnName("ComDep__CompanyDepartmentID");
        entity.Property(e => e.ComDepDescription)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("ComDep__Description");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCompanyDepartment> entity);
}
