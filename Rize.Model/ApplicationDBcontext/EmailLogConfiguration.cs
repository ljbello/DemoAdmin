using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class EmailLogConfiguration : IEntityTypeConfiguration<EmailLog>
{
    public void Configure(EntityTypeBuilder<EmailLog> entity)
    {
        entity.ToTable("EmailLog");

        entity.HasIndex(e => new { e.OrderId, e.EmailTypeId }, "EmailLog_IX1");

        entity.HasIndex(e => e.EmailTypeId, "EmailLog_IX2");

        entity.HasIndex(e => new { e.StoreId, e.ToEmailAddress, e.EmailTypeId, e.IsSuccessful, e.QueuedDate }, "EmailLog_IX3");

        entity.HasIndex(e => new { e.EmailTypeId, e.IsSuccessful, e.Ignore, e.Delivered, e.Bounced, e.SubmittedDate }, "EmailLog_IX4");

        entity.HasIndex(e => new { e.EmailTypeId, e.IsSuccessful, e.ShouldRetry, e.SendAttempts, e.QueuedDate }, "IDX_EmailLog_ToProcess");

        entity.Property(e => e.EmailLogId).HasDefaultValueSql("(newid())");
        entity.Property(e => e.CreatedBy).HasDefaultValue(1);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.LastErrorMessage).IsUnicode(false);
        entity.Property(e => e.Message)
                .HasMaxLength(2048)
                .IsUnicode(false);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.QueuedDate).HasColumnType("datetime");
        entity.Property(e => e.RequestId)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.SubmittedDate).HasColumnType("datetime");
        entity.Property(e => e.ToEmailAddress)
                .HasMaxLength(255)
                .IsUnicode(false);

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.EmailLogs)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailLog_tblUsers");

        entity.HasOne(d => d.EmailType).WithMany(p => p.EmailLogs)
                .HasForeignKey(d => d.EmailTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailLog_EmailTypes");

        entity.HasOne(d => d.Store).WithMany(p => p.EmailLogs)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_EmailLog_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<EmailLog> entity);
}
