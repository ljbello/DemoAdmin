using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblDepartmentConfiguration : IEntityTypeConfiguration<TblDepartment>
{
    public void Configure(EntityTypeBuilder<TblDepartment> entity)
    {
        entity.HasKey(e => e.DepDepartmentId).HasName("tblDepartments_PK");

        entity.ToTable("tblDepartments");

        entity.HasIndex(e => e.DepDepartmentId, "IX_UniqueDepartmentName").IsUnique();

        entity.Property(e => e.DepDepartmentId).HasColumnName("Dep__DepartmentID");
        entity.Property(e => e.DepChildCount).HasColumnName("Dep__ChildCount");
        entity.Property(e => e.DepDefaultVerseGroup).HasColumnName("Dep__DefaultVerseGroup");
        entity.Property(e => e.DepHierarchicalSort).HasColumnName("Dep__HierarchicalSort");
        entity.Property(e => e.DepLevel).HasColumnName("Dep__Level");
        entity.Property(e => e.DepName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Dep__Name");
        entity.Property(e => e.DepParentDepartmentId).HasColumnName("Dep__ParentDepartmentID");
        entity.Property(e => e.DepRank)
                .HasDefaultValue(1000)
                .HasColumnName("Dep__Rank");
        entity.Property(e => e.DepShowInTopMenu).HasColumnName("Dep__ShowInTopMenu");

        entity.HasOne(d => d.DepParentDepartment).WithMany(p => p.InverseDepParentDepartment)
                .HasForeignKey(d => d.DepParentDepartmentId)
                .HasConstraintName("FK_tblDepartments_tblDepartments");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblDepartment> entity);
}
