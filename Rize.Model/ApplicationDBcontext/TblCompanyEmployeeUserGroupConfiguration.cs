using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCompanyEmployeeUserGroupConfiguration : IEntityTypeConfiguration<TblCompanyEmployeeUserGroup>
{
    public void Configure(EntityTypeBuilder<TblCompanyEmployeeUserGroup> entity)
    {
        entity.HasKey(e => e.ComEmpUseGroCompanyEmployeeUserGroupId);

        entity.ToTable("tblCompanyEmployeeUserGroups");

        entity.Property(e => e.ComEmpUseGroCompanyEmployeeUserGroupId)
                .ValueGeneratedNever()
                .HasColumnName("ComEmpUseGro__CompanyEmployeeUserGroupID");
        entity.Property(e => e.ComEmpUseGroAuthorizationLevel).HasColumnName("ComEmpUseGro__AuthorizationLevel");
        entity.Property(e => e.ComEmpUseGroDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("ComEmpUseGro__Description");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCompanyEmployeeUserGroup> entity);
}
