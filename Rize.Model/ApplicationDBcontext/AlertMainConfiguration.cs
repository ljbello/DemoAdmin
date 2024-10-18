using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AlertMainConfiguration : IEntityTypeConfiguration<AlertMain>
{
    public void Configure(EntityTypeBuilder<AlertMain> entity)
    {
        entity.ToTable("AlertMain");

        entity.Property(e => e.AlertMainId).HasColumnName("AlertMainID");
        entity.Property(e => e.AlertCode)
                .HasMaxLength(5000)
                .IsUnicode(false);
        entity.Property(e => e.AlertName)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.IsActive).HasDefaultValue(true);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AlertMain> entity);
}
