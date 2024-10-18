using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AutoTriggerWhenFieldConfiguration : IEntityTypeConfiguration<AutoTriggerWhenField>
{
    public void Configure(EntityTypeBuilder<AutoTriggerWhenField> entity)
    {
        entity.ToTable("AutoTriggerWhenField");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.DisplayName)
                .HasMaxLength(150)
                .IsUnicode(false);
        entity.Property(e => e.FieldName)
                .HasMaxLength(150)
                .IsUnicode(false);
        entity.Property(e => e.JoinQuery).IsUnicode(false);
        entity.Property(e => e.TableName)
                .HasMaxLength(150)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AutoTriggerWhenField> entity);
}
