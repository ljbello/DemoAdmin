using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ExactTargetEmailTypeConfiguration : IEntityTypeConfiguration<ExactTargetEmailType>
{
    public void Configure(EntityTypeBuilder<ExactTargetEmailType> entity)
    {
        entity.HasKey(e => e.EmailTypeId);

        entity.Property(e => e.EmailLookUpId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
        entity.Property(e => e.Priority).HasDefaultValue(50);
        entity.Property(e => e.SendType).HasDefaultValue(1);
        entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.TriggerSendKey)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ExactTargetEmailType> entity);
}
