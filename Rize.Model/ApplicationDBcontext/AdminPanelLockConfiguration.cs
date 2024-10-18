using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AdminPanelLockConfiguration : IEntityTypeConfiguration<AdminPanelLock>
{
    public void Configure(EntityTypeBuilder<AdminPanelLock> entity)
    {
        entity.HasIndex(e => new { e.PanelId, e.LockKey }, "IX_AdminPanelLocks_PanelIDLockKey");

        entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
        entity.Property(e => e.LockKey).HasMaxLength(100);
        entity.Property(e => e.LockedOn).HasColumnType("datetime");
        entity.Property(e => e.PanelId).HasColumnName("PanelID");

        entity.HasOne(d => d.LockedByNavigation).WithMany(p => p.AdminPanelLocks)
                .HasForeignKey(d => d.LockedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdminPanelLocks_User");

        entity.HasOne(d => d.Panel).WithMany(p => p.AdminPanelLocks)
                .HasForeignKey(d => d.PanelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdminPanelLocks_Panel");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AdminPanelLock> entity);
}
