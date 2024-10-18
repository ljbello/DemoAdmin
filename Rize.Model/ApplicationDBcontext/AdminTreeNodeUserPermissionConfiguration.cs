using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AdminTreeNodeUserPermissionConfiguration : IEntityTypeConfiguration<AdminTreeNodeUserPermission>
{
    public void Configure(EntityTypeBuilder<AdminTreeNodeUserPermission> entity)
    {
        entity.HasKey(e => new { e.UserId, e.TreeNodeId }).HasName("PK__AdminTre__3B9B34D5ABA99FA2");

        entity.ToTable("AdminTreeNodeUserPermission");

        entity.Property(e => e.UserId).HasColumnName("UserID");
        entity.Property(e => e.TreeNodeId).HasColumnName("TreeNodeID");

        entity.HasOne(d => d.TreeNode).WithMany(p => p.AdminTreeNodeUserPermissions)
                .HasForeignKey(d => d.TreeNodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdminTreeNodeUserPermission_AdminTreeNode");

        entity.HasOne(d => d.User).WithMany(p => p.AdminTreeNodeUserPermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdminTreeNodeUserPermission_tblUsers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AdminTreeNodeUserPermission> entity);
}
