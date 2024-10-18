using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ServiceConfiguration : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> entity)
    {
        entity.ToTable("Service");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Command)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Created).HasColumnType("datetime");
        entity.Property(e => e.CurrentVersion)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.EndDate).HasDefaultValue(new DateOnly(2061, 1, 1));
        entity.Property(e => e.Frequency).HasDefaultValue(60);
        entity.Property(e => e.HeartbeatFrequency).HasDefaultValue(60000);
        entity.Property(e => e.Interval)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("seconds");
        entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
        entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ScheduledBeginTime).HasPrecision(0);
        entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceTypeID");
        entity.Property(e => e.StartDate).HasDefaultValue(new DateOnly(2011, 1, 1));
        entity.Property(e => e.StatusTypeId).HasColumnName("StatusTypeID");
        entity.Property(e => e.Updated).HasColumnType("datetime");

        entity.HasOne(d => d.ServiceType).WithMany(p => p.Services)
                .HasForeignKey(d => d.ServiceTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Service_ServiceType");

        entity.HasOne(d => d.StatusType).WithMany(p => p.Services)
                .HasForeignKey(d => d.StatusTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Service_ServiceStatusType");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Service> entity);
}
