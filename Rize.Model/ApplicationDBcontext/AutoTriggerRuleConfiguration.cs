using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AutoTriggerRuleConfiguration : IEntityTypeConfiguration<AutoTriggerRule>
{
    public void Configure(EntityTypeBuilder<AutoTriggerRule> entity)
    {
        entity.ToTable("AutoTriggerRule");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.AutoTriggerId).HasColumnName("AutoTriggerID");
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.Operator)
                .HasMaxLength(15)
                .IsUnicode(false);
        entity.Property(e => e.WhenCondition)
                .HasMaxLength(15)
                .IsUnicode(false);
        entity.Property(e => e.WhenFieldId).HasColumnName("WhenFieldID");
        entity.Property(e => e.WhenValue)
                .HasMaxLength(600)
                .IsUnicode(false);

        entity.HasOne(d => d.AutoTrigger).WithMany(p => p.AutoTriggerRules)
                .HasForeignKey(d => d.AutoTriggerId)
                .HasConstraintName("FK_AutoTriggerRule_AutoTrigger");

        entity.HasOne(d => d.WhenField).WithMany(p => p.AutoTriggerRules)
                .HasForeignKey(d => d.WhenFieldId)
                .HasConstraintName("FK_AutoTriggerRule_AutoTriggerWhenField");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AutoTriggerRule> entity);
}
