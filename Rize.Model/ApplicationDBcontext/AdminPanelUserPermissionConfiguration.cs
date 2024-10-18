using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AdminPanelUserPermissionConfiguration : IEntityTypeConfiguration<AdminPanelUserPermission>
{
    public void Configure(EntityTypeBuilder<AdminPanelUserPermission> entity)
    {
        entity.ToTable("AdminPanelUserPermission");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.PanelId).HasColumnName("PanelID");
        entity.Property(e => e.TreeNodeId).HasColumnName("TreeNodeID");
        entity.Property(e => e.UserId).HasColumnName("UserID");

        entity.HasOne(d => d.Panel).WithMany(p => p.AdminPanelUserPermissions)
                .HasForeignKey(d => d.PanelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdminPanelUserPermission_AdminPanel");

        entity.HasOne(d => d.TreeNode).WithMany(p => p.AdminPanelUserPermissions)
                .HasForeignKey(d => d.TreeNodeId)
                .HasConstraintName("FK_AdminPanelUserPermission_AdminTreeNode");

        entity.HasOne(d => d.User).WithMany(p => p.AdminPanelUserPermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdminPanelUserPermission_tblUsers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AdminPanelUserPermission> entity);
}
