using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SavedProjectConfiguration : IEntityTypeConfiguration<SavedProject>
{
    public void Configure(EntityTypeBuilder<SavedProject> entity)
    {
        entity.HasIndex(e => e.ModifiedOn, "SavedProjects_IX1");

        entity.HasIndex(e => new { e.CustomerLoginId, e.Deleted }, "SavedProjects_IX2");

        entity.HasIndex(e => new { e.CustomerLoginId, e.ProjectName, e.Deleted }, "SavedProjects_IX3");

        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ModifiedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.PreviewVersion).HasDefaultValue(3);
        entity.Property(e => e.ProjectName)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.ProjectXml)
                .HasColumnType("xml")
                .HasColumnName("ProjectXML");

        entity.HasOne(d => d.CustomerLogin).WithMany(p => p.SavedProjects)
                .HasForeignKey(d => d.CustomerLoginId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SavedProjects_CustomerLogins");

        entity.HasOne(d => d.Product).WithMany(p => p.SavedProjects)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SavedProjects_tblProducts");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SavedProject> entity);
}
