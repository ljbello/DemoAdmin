using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblUserDepartmentConfiguration : IEntityTypeConfiguration<TblUserDepartment>
{
    public void Configure(EntityTypeBuilder<TblUserDepartment> entity)
    {
        entity.HasKey(e => e.DepartmentId);

        entity.ToTable("tblUserDepartments");

        entity.HasIndex(e => e.Rowguid, "MSmerge_index_768994812")
                .IsUnique()
                .HasFillFactor(95);

        entity.Property(e => e.DepartmentId)
                .ValueGeneratedNever()
                .HasColumnName("DepartmentID");
        entity.Property(e => e.Description)
                .HasMaxLength(64)
                .IsUnicode(false);
        entity.Property(e => e.Rowguid)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("rowguid");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblUserDepartment> entity);
}
