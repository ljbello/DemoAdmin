using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ViewOrderNotificationStatusConfiguration : IEntityTypeConfiguration<ViewOrderNotificationStatus>
{
    public void Configure(EntityTypeBuilder<ViewOrderNotificationStatus> entity)
    {
        entity
                .HasNoKey()
                .ToView("viewOrderNotificationStatus");

        entity.Property(e => e.ScheduledTime).HasColumnType("datetime");
        entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ViewOrderNotificationStatus> entity);
}
