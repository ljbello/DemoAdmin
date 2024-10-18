using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AreaDefaultConfiguration : IEntityTypeConfiguration<AreaDefault>
{
    public void Configure(EntityTypeBuilder<AreaDefault> entity)
    {
        entity.HasIndex(e => e.ProductId, "AreaDefaults_IX1");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.FontColor)
                .HasMaxLength(15)
                .IsUnicode(false);
        entity.Property(e => e.FontName)
                .HasMaxLength(150)
                .IsUnicode(false);
        entity.Property(e => e.ModifiedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.PreviewGroup)
                .HasMaxLength(30)
                .IsUnicode(false);

        entity.HasOne(d => d.AreaName).WithMany(p => p.AreaDefaults)
                .HasForeignKey(d => d.AreaNameId)
                .HasConstraintName("FK_AreaDefaults_AreaName");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AreaDefault> entity);
}
