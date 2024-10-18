using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SampleRequestEmailReminderConfiguration : IEntityTypeConfiguration<SampleRequestEmailReminder>
{
    public void Configure(EntityTypeBuilder<SampleRequestEmailReminder> entity)
    {
        entity.ToTable("SampleRequestEmailReminder");

        entity.HasIndex(e => new { e.OrdContactEmail, e.CreatedOn }, "SampleRequestEmailReminder_IX1");

        entity.HasIndex(e => e.OrdOrderId, "SampleRequestEmailReminder_IX2");

        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.EmailId).HasColumnName("EmailID");
        entity.Property(e => e.EmailNumber).HasDefaultValue(1);
        entity.Property(e => e.OrdContactEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Ord__ContactEmail");
        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SampleRequestEmailReminder> entity);
}
