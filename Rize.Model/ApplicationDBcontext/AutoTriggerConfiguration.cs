using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AutoTriggerConfiguration : IEntityTypeConfiguration<AutoTrigger>
{
    public void Configure(EntityTypeBuilder<AutoTrigger> entity)
    {
        entity.ToTable("AutoTrigger");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
        entity.Property(e => e.LastRun).HasColumnType("datetime");
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.RuleName)
                .HasMaxLength(200)
                .IsUnicode(false);
        entity.Property(e => e.SqlQuery).IsUnicode(false);
        entity.Property(e => e.StoreId).HasColumnName("StoreID");

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.AutoTriggerCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_AutoTrigger_Users1");

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.AutoTriggerModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_AutoTrigger_Users2");

        entity.HasOne(d => d.Store).WithMany(p => p.AutoTriggers)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_AutoTrigger_Store");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AutoTrigger> entity);
}
