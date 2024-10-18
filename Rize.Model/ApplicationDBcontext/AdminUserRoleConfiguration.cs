using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AdminUserRoleConfiguration : IEntityTypeConfiguration<AdminUserRole>
{
    public void Configure(EntityTypeBuilder<AdminUserRole> entity)
    {
        entity.HasKey(e => e.UserRoleId);

        entity.ToTable("AdminUserRole");

        entity.HasIndex(e => new { e.RoleId, e.UserId }, "IX_AdminUserRole_RoleIdUserId").IsUnique();

        entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
        entity.Property(e => e.CreatedBy).HasDefaultValue(0);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.RoleId).HasColumnName("RoleID");
        entity.Property(e => e.UserId).HasColumnName("UserID");

        entity.HasOne(d => d.Role).WithMany(p => p.AdminUserRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdminUserRole_AdminRole");

        entity.HasOne(d => d.User).WithMany(p => p.AdminUserRoles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdminUserRole_tblUsers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AdminUserRole> entity);
}
