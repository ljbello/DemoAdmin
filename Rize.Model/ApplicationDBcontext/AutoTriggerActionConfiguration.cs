using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AutoTriggerActionConfiguration : IEntityTypeConfiguration<AutoTriggerAction>
{
    public void Configure(EntityTypeBuilder<AutoTriggerAction> entity)
    {
        entity.ToTable("AutoTriggerAction");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.ActionId).HasColumnName("ActionID");
        entity.Property(e => e.ActionValue)
                .HasMaxLength(800)
                .IsUnicode(false);
        entity.Property(e => e.AutoTriggerId).HasColumnName("AutoTriggerID");

        entity.HasOne(d => d.Action).WithMany(p => p.AutoTriggerActions)
                .HasForeignKey(d => d.ActionId)
                .HasConstraintName("FK_AutoTriggerAction_AutoTriggerActionLookUp");

        entity.HasOne(d => d.AutoTrigger).WithMany(p => p.AutoTriggerActions)
                .HasForeignKey(d => d.AutoTriggerId)
                .HasConstraintName("FK_AutoTriggerAction_AutoTrigger");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AutoTriggerAction> entity);
}
