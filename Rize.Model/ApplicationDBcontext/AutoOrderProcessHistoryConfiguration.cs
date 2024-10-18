using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AutoOrderProcessHistoryConfiguration : IEntityTypeConfiguration<AutoOrderProcessHistory>
{
    public void Configure(EntityTypeBuilder<AutoOrderProcessHistory> entity)
    {
        entity.ToTable("AutoOrderProcessHistory");

        entity.HasIndex(e => e.OrdOrderId, "IX_AutoOrderProcessHistory_OrderId");

        entity.Property(e => e.AutoOrderProcessHistoryId).HasDefaultValueSql("(newid())");
        entity.Property(e => e.DateTimeCompleted)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderId");
        entity.Property(e => e.Result).HasDefaultValue(true);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AutoOrderProcessHistory> entity);
}
