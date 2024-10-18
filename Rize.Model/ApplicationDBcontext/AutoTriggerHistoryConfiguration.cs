using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AutoTriggerHistoryConfiguration : IEntityTypeConfiguration<AutoTriggerHistory>
{
    public void Configure(EntityTypeBuilder<AutoTriggerHistory> entity)
    {
        entity.ToTable("AutoTriggerHistory");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.AutoTriggerId).HasColumnName("AutoTriggerID");
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.OrderId).HasColumnName("OrderID");

        entity.HasOne(d => d.AutoTrigger).WithMany(p => p.AutoTriggerHistories)
                .HasForeignKey(d => d.AutoTriggerId)
                .HasConstraintName("FK_AutoTriggerHistory_AutoTrigger");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AutoTriggerHistory> entity);
}
