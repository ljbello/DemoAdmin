using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class EmailSubscriptionConfiguration : IEntityTypeConfiguration<EmailSubscription>
{
    public void Configure(EntityTypeBuilder<EmailSubscription> entity)
    {
        entity.HasIndex(e => new { e.StoreId, e.Email }, "EmailSubscriptions_IX1");

        entity.HasIndex(e => new { e.Email, e.StoreId }, "Index_UniqueEmail").IsUnique();

        entity.Property(e => e.EmailSubscriptionId).HasDefaultValueSql("(newid())");
        entity.Property(e => e.AllowSms).HasColumnName("AllowSMS");
        entity.Property(e => e.BirthdayDate).HasColumnType("datetime");
        entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.DateUnsubscribed).HasColumnType("datetime");
        entity.Property(e => e.Email).HasMaxLength(100);
        entity.Property(e => e.FirstName).HasMaxLength(50);
        entity.Property(e => e.FrequencyOfEmails).HasMaxLength(50);
        entity.Property(e => e.LastName).HasMaxLength(50);
        entity.Property(e => e.Mobile)
                .HasMaxLength(10)
                .IsUnicode(false);
        entity.Property(e => e.StoreId)
                .HasDefaultValue(1)
                .HasColumnName("StoreID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<EmailSubscription> entity);
}
