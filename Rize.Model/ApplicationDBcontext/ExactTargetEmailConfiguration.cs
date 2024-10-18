using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ExactTargetEmailConfiguration : IEntityTypeConfiguration<ExactTargetEmail>
{
    public void Configure(EntityTypeBuilder<ExactTargetEmail> entity)
    {
        entity.HasIndex(e => new { e.OrderId, e.EmailTypeId, e.IsPreview }, "ExactTargetEmails_IX1");

        entity.HasIndex(e => new { e.EmailTypeId, e.IsSuccessful, e.ShouldRetry, e.SendAttempts, e.QueuedDate }, "IDX_ExactTargetEmails_ToProcess");

        entity.Property(e => e.ExactTargetEmailId).HasDefaultValueSql("(newid())");
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
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.SubmittedDate).HasColumnType("datetime");
        entity.Property(e => e.ToEmailAddress)
                .HasMaxLength(255)
                .IsUnicode(false);

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ExactTargetEmails)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExactTargetEmails_tblUsers");

        entity.HasOne(d => d.EmailType).WithMany(p => p.ExactTargetEmails)
                .HasForeignKey(d => d.EmailTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExactTargetEmails_ExactTargetEmailTypes");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ExactTargetEmail> entity);
}
