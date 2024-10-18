using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AdminShortcutConfiguration : IEntityTypeConfiguration<AdminShortcut>
{
    public void Configure(EntityTypeBuilder<AdminShortcut> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__AdminSho__3214EC074D66C83B");

        entity.ToTable("AdminShortcut");

        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Name).HasMaxLength(100);
        entity.Property(e => e.Url).HasMaxLength(255);

        entity.HasOne(d => d.User).WithMany(p => p.AdminShortcuts)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdminShortcut_tblUsers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AdminShortcut> entity);
}
