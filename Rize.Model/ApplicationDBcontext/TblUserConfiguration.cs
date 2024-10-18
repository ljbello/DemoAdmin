using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblUserConfiguration : IEntityTypeConfiguration<TblUser>
{
    public void Configure(EntityTypeBuilder<TblUser> entity)
    {
        entity.HasKey(e => e.UserId);

        entity.ToTable("tblUsers");

        entity.HasIndex(e => e.Username, "IX_tblUsers_Username");

        entity.HasIndex(e => e.Rowguid, "MSmerge_index_816994983")
                .IsUnique()
                .HasFillFactor(95);

        entity.HasIndex(e => new { e.UserId, e.Initials }, "_dta_index_tblUsers_7_1357989406__K1_K5");

        entity.HasIndex(e => e.EmailAddress, "tblUsers_IX1");

        entity.HasIndex(e => e.Initials, "tblUsers_IX2");

        entity.HasIndex(e => e.EmployeeId, "tblUsers_IX3");

        entity.Property(e => e.UserId).HasColumnName("UserID");
        entity.Property(e => e.Active).HasDefaultValue(false);
        entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.DateHired).HasColumnType("datetime");
        entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
        entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
        entity.Property(e => e.FirstName)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.Initials)
                .HasMaxLength(3)
                .IsUnicode(false);
        entity.Property(e => e.LastLogin)
                .HasColumnType("datetime")
                .HasColumnName("LastLogin ");
        entity.Property(e => e.LastName)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.LockoutEndDate).HasColumnType("datetime");
        entity.Property(e => e.MiddleInitial)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        entity.Property(e => e.Notes).IsUnicode(false);
        entity.Property(e => e.NtuserName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NTUserName");
        entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.PasswordResetRequestDate).HasColumnType("datetime");
        entity.Property(e => e.Rowguid)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("rowguid");
        entity.Property(e => e.SessionId).HasColumnName("SessionID");
        entity.Property(e => e.SharedSessionId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SharedSessionID");
        entity.Property(e => e.TwoFormAuthCreatedDate).HasColumnType("datetime");
        entity.Property(e => e.TwoFormAuthEnabled).HasDefaultValue(true);
        entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);

        entity.HasOne(d => d.Department).WithMany(p => p.TblUsers)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblUsers_tblUserDepartments");

        entity.HasOne(d => d.Employee).WithMany(p => p.TblUsers)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblUsers_tblCompanyEmployees");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblUser> entity);
}
