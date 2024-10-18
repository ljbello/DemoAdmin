using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ServiceMonitorLogConfiguration : IEntityTypeConfiguration<ServiceMonitorLog>
{
    public void Configure(EntityTypeBuilder<ServiceMonitorLog> entity)
    {
        entity.ToTable("ServiceMonitorLog");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.AppName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.EmailBody).IsUnicode(false);
        entity.Property(e => e.EmailSubject)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.EmailTo)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.MonitoringAppName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Result)
                .HasMaxLength(200)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ServiceMonitorLog> entity);
}
