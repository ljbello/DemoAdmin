using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CommandLogConfiguration : IEntityTypeConfiguration<CommandLog>
{
    public void Configure(EntityTypeBuilder<CommandLog> entity)
    {
        entity.ToTable("CommandLog");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CommandType).HasMaxLength(60);
        entity.Property(e => e.DatabaseName).HasMaxLength(128);
        entity.Property(e => e.ExtendedInfo).HasColumnType("xml");
        entity.Property(e => e.IndexName).HasMaxLength(128);
        entity.Property(e => e.ObjectName).HasMaxLength(128);
        entity.Property(e => e.ObjectType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        entity.Property(e => e.SchemaName).HasMaxLength(128);
        entity.Property(e => e.StatisticsName).HasMaxLength(128);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CommandLog> entity);
}
