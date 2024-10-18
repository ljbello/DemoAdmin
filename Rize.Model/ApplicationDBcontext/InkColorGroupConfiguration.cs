using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class InkColorGroupConfiguration : IEntityTypeConfiguration<InkColorGroup>
{
    public void Configure(EntityTypeBuilder<InkColorGroup> entity)
    {
        entity.ToTable("InkColorGroup");

        entity.Property(e => e.Active).HasDefaultValue(true);
        entity.Property(e => e.CreatedBy).HasDefaultValue(1);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Name).HasMaxLength(50);
        entity.Property(e => e.ProductionTypeId).HasColumnName("ProductionTypeID");

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.InkColorGroups)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InkColorGroup_tblUsers");

        entity.HasOne(d => d.ProductionType).WithMany(p => p.InkColorGroups)
                .HasForeignKey(d => d.ProductionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InkColorGroup_ProductionType");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<InkColorGroup> entity);
}
