using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AdminTreeNodeRoleConfiguration : IEntityTypeConfiguration<AdminTreeNodeRole>
{
    public void Configure(EntityTypeBuilder<AdminTreeNodeRole> entity)
    {
        entity.HasKey(e => e.TreeNodeRoleId);

        entity.ToTable("AdminTreeNodeRole");

        entity.HasIndex(e => new { e.RoleId, e.TreeNodeId }, "IX_AdminTreeNodeRole_UniqueRoleIDTreeNodeID").IsUnique();

        entity.Property(e => e.TreeNodeRoleId).HasColumnName("TreeNodeRoleID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.RoleId).HasColumnName("RoleID");
        entity.Property(e => e.TreeNodeId).HasColumnName("TreeNodeID");

        entity.HasOne(d => d.Role).WithMany(p => p.AdminTreeNodeRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdminTreeNodeRole_AdminRole");

        entity.HasOne(d => d.TreeNode).WithMany(p => p.AdminTreeNodeRoles)
                .HasForeignKey(d => d.TreeNodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdminTreeNodeRole_AdminTreeNode");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AdminTreeNodeRole> entity);
}
