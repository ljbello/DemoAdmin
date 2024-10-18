using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class EmailTypeConfiguration : IEntityTypeConfiguration<EmailType>
{
    public void Configure(EntityTypeBuilder<EmailType> entity)
    {
        entity.ToTable("EmailType");

        entity.Property(e => e.AllowUnsubscribe).HasDefaultValue(true);
        entity.Property(e => e.CreatedBy).HasDefaultValue(1);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.EmailLookUpId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
        entity.Property(e => e.Priority).HasDefaultValue(50);
        entity.Property(e => e.SendType).HasDefaultValue(1);
        entity.Property(e => e.State).HasDefaultValue(true);
        entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.TriggerSendKey)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.EmailTypes)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailType_tblUsers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<EmailType> entity);
}
