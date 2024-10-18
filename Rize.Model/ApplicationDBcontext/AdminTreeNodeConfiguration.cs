using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AdminTreeNodeConfiguration : IEntityTypeConfiguration<AdminTreeNode>
{
    public void Configure(EntityTypeBuilder<AdminTreeNode> entity)
    {
        entity.HasKey(e => e.TreeNodeId);

        entity.ToTable("AdminTreeNode");

        entity.Property(e => e.TreeNodeId).HasColumnName("TreeNodeID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.DisplayName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ExternalUrl).HasMaxLength(255);
        entity.Property(e => e.MenuType).HasDefaultValue(1);
        entity.Property(e => e.NodeIconId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NodeIconID");
        entity.Property(e => e.PageId).HasColumnName("PageID");
        entity.Property(e => e.ParentTreeNodeId).HasColumnName("ParentTreeNodeID");
        entity.Property(e => e.ScriptCode).HasMaxLength(255);
        entity.Property(e => e.ShowDataCount).HasDefaultValue(false);

        entity.HasOne(d => d.Page).WithMany(p => p.AdminTreeNodes)
                .HasForeignKey(d => d.PageId)
                .HasConstraintName("FK_AdminTreeNode_AdminPage");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AdminTreeNode> entity);
}
