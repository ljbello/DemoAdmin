using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AlertNotifierConfiguration : IEntityTypeConfiguration<AlertNotifier>
{
    public void Configure(EntityTypeBuilder<AlertNotifier> entity)
    {
        entity.HasKey(e => e.AlertNotifier1);

        entity.ToTable("AlertNotifier");

        entity.Property(e => e.AlertNotifier1).HasColumnName("AlertNotifier");
        entity.Property(e => e.AlertMainId).HasColumnName("AlertMainID");
        entity.Property(e => e.AlertRecipientId).HasColumnName("AlertRecipientID");
        entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.IsActive).HasDefaultValue(true);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AlertNotifier> entity);
}
