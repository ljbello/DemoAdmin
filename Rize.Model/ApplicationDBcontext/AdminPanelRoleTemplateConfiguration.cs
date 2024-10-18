using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AdminPanelRoleTemplateConfiguration : IEntityTypeConfiguration<AdminPanelRoleTemplate>
{
    public void Configure(EntityTypeBuilder<AdminPanelRoleTemplate> entity)
    {
        entity.ToTable("AdminPanelRoleTemplate");

        entity.Property(e => e.PanelId).HasColumnName("PanelID");
        entity.Property(e => e.RoleId).HasColumnName("RoleID");
        entity.Property(e => e.TreeNodeId).HasColumnName("TreeNodeID");

        entity.HasOne(d => d.Panel).WithMany(p => p.AdminPanelRoleTemplates)
                .HasForeignKey(d => d.PanelId)
                .HasConstraintName("FK_AdminPanelRoleTemplate_AdminPanel");

        entity.HasOne(d => d.Role).WithMany(p => p.AdminPanelRoleTemplates)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_AdminPanelRoleTemplate_AdminRole");

        entity.HasOne(d => d.TreeNode).WithMany(p => p.AdminPanelRoleTemplates)
                .HasForeignKey(d => d.TreeNodeId)
                .HasConstraintName("FK_AdminPanelRoleTemplate_AdminTreeNode");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AdminPanelRoleTemplate> entity);
}
