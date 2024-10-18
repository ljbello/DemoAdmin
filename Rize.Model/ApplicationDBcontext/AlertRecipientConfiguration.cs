using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AlertRecipientConfiguration : IEntityTypeConfiguration<AlertRecipient>
{
    public void Configure(EntityTypeBuilder<AlertRecipient> entity)
    {
        entity.ToTable("AlertRecipient");

        entity.Property(e => e.AlertRecipientId).HasColumnName("AlertRecipientID");
        entity.Property(e => e.AlertRecipientEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.AlertRecipientName)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.IsActive).HasDefaultValue(true);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AlertRecipient> entity);
}
