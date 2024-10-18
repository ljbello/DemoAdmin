using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AdminPagePanelConfiguration : IEntityTypeConfiguration<AdminPagePanel>
{
    public void Configure(EntityTypeBuilder<AdminPagePanel> entity)
    {
        entity.ToTable("AdminPagePanel");

        entity.HasIndex(e => new { e.PageId, e.PanelId }, "IX_AdminPagePanel").IsUnique();

        entity.HasIndex(e => e.PageId, "IX_AdminPagePanel_Page");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.PageId).HasColumnName("PageID");
        entity.Property(e => e.PanelId).HasColumnName("PanelID");

        entity.HasOne(d => d.Page).WithMany(p => p.AdminPagePanels)
                .HasForeignKey(d => d.PageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdminPagePanel_Page");

        entity.HasOne(d => d.Panel).WithMany(p => p.AdminPagePanels)
                .HasForeignKey(d => d.PanelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdminPagePanel_Panel");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AdminPagePanel> entity);
}
