using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCompanyEmployeeStatusConfiguration : IEntityTypeConfiguration<TblCompanyEmployeeStatus>
{
    public void Configure(EntityTypeBuilder<TblCompanyEmployeeStatus> entity)
    {
        entity.HasKey(e => e.ComEmpStaCompanyEmployeeStatusId);

        entity.ToTable("tblCompanyEmployeeStatus");

        entity.Property(e => e.ComEmpStaCompanyEmployeeStatusId)
                .ValueGeneratedNever()
                .HasColumnName("ComEmpSta__CompanyEmployeeStatusID");
        entity.Property(e => e.ComEmpStaDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("ComEmpSta__Description");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCompanyEmployeeStatus> entity);
}
