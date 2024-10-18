using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AdminPanelConfiguration : IEntityTypeConfiguration<AdminPanel>
{
    public void Configure(EntityTypeBuilder<AdminPanel> entity)
    {
        entity.ToTable("AdminPanel");

        entity.HasIndex(e => e.ClassName, "IX_AdminPanel_ClassName").IsUnique();

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.ClassName)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AdminPanel> entity);
}
