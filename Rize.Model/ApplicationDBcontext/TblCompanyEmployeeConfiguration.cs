using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCompanyEmployeeConfiguration : IEntityTypeConfiguration<TblCompanyEmployee>
{
    public void Configure(EntityTypeBuilder<TblCompanyEmployee> entity)
    {
        entity.HasKey(e => e.ComEmpCompanyEmployeeId);

        entity.ToTable("tblCompanyEmployees");

        entity.HasIndex(e => e.ComEmpStaCompanyEmployeeStatusId, "IX_tblCompanyEmployees_StatusID");

        entity.Property(e => e.ComEmpCompanyEmployeeId).HasColumnName("ComEmp__CompanyEmployeeID");
        entity.Property(e => e.ComDepCompanyDepartmentId).HasColumnName("ComDep__CompanyDepartmentID");
        entity.Property(e => e.ComEmpDisplaySequenceArtwork).HasColumnName("ComEmp__DisplaySequence_Artwork");
        entity.Property(e => e.ComEmpFirstName)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("ComEmp__FirstName");
        entity.Property(e => e.ComEmpInitials)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ComEmp__Initials");
        entity.Property(e => e.ComEmpLastName)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("ComEmp__LastName");
        entity.Property(e => e.ComEmpMiddleInitial)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ComEmp__MiddleInitial");
        entity.Property(e => e.ComEmpStaCompanyEmployeeStatusId).HasColumnName("ComEmpSta__CompanyEmployeeStatusID");
        entity.Property(e => e.ComEmpUseGroCompanyEmployeeUserGroupId).HasColumnName("ComEmpUseGro__CompanyEmployeeUserGroupID");
        entity.Property(e => e.ComEmpUserName)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("ComEmp__UserName");
        entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.DefaultStartPage)
                .HasMaxLength(255)
                .IsUnicode(false);
        entity.Property(e => e.EmployeeNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.GoogleId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GoogleID");
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.Nickname)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.Notes).HasMaxLength(800);
        entity.Property(e => e.PhoneMobile)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.PhoneOffice)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.SkypeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SkypeID");
        entity.Property(e => e.SupervisorId).HasColumnName("SupervisorID ");
        entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.TitleDescription).HasMaxLength(800);

        entity.HasOne(d => d.ComDepCompanyDepartment).WithMany(p => p.TblCompanyEmployees)
                .HasForeignKey(d => d.ComDepCompanyDepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCompanyEmployees_tblCompanyDepartments");

        entity.HasOne(d => d.ComEmpStaCompanyEmployeeStatus).WithMany(p => p.TblCompanyEmployees)
                .HasForeignKey(d => d.ComEmpStaCompanyEmployeeStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCompanyEmployees_tblCompanyEmployeeStatus");

        entity.HasOne(d => d.ComEmpUseGroCompanyEmployeeUserGroup).WithMany(p => p.TblCompanyEmployees)
                .HasForeignKey(d => d.ComEmpUseGroCompanyEmployeeUserGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCompanyEmployees_tblCompanyEmployeeUserGroups");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCompanyEmployee> entity);
}
