using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class StoreEmailReminderScheduleConfiguration : IEntityTypeConfiguration<StoreEmailReminderSchedule>
{
    public void Configure(EntityTypeBuilder<StoreEmailReminderSchedule> entity)
    {
        entity.ToTable("StoreEmailReminderSchedule");

        entity.Property(e => e.EmailTypeId).HasColumnName("EmailTypeID");
        entity.Property(e => e.ReminderType)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.SubscriberEmailCode)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<StoreEmailReminderSchedule> entity);
}
