using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ErrorLogConfiguration : IEntityTypeConfiguration<ErrorLog>
{
    public void Configure(EntityTypeBuilder<ErrorLog> entity)
    {
        entity
                .HasNoKey()
                .ToTable("ErrorLog");

        entity.Property(e => e.ErrorDate).HasColumnType("datetime");
        entity.Property(e => e.ErrorLogId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ErrorLogID");
        entity.Property(e => e.ErrorMessage)
                .HasMaxLength(8000)
                .IsUnicode(false);
        entity.Property(e => e.ProcName)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ErrorLog> entity);
}
