using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SaveProjectReminderConfiguration : IEntityTypeConfiguration<SaveProjectReminder>
{
    public void Configure(EntityTypeBuilder<SaveProjectReminder> entity)
    {
        entity.ToTable("SaveProjectReminder");

        entity.HasIndex(e => new { e.CustomerLoginId, e.CreatedOn }, "SaveProjectReminder_IX1");

        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SaveProjectReminder> entity);
}
