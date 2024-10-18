using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ServiceMessageConfiguration : IEntityTypeConfiguration<ServiceMessage>
{
    public void Configure(EntityTypeBuilder<ServiceMessage> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK_ServiceMessage_1");

        entity.ToTable("ServiceMessage");

        entity.HasIndex(e => e.ServiceId, "IX_ServiceMessage_ServiceID");

        entity.HasIndex(e => e.Created, "ServiceMessage_IX1");

        entity.HasIndex(e => new { e.ServiceId, e.ServiceMessageTypeId }, "ServiceMessage_IX2");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Created).HasColumnType("datetime");
        entity.Property(e => e.Message).IsUnicode(false);
        entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
        entity.Property(e => e.ServiceMessageTypeId).HasColumnName("ServiceMessageTypeID");
        entity.Property(e => e.Updated).HasColumnType("datetime");

        entity.HasOne(d => d.Service).WithMany(p => p.ServiceMessages)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceMessage_Service");

        entity.HasOne(d => d.ServiceMessageType).WithMany(p => p.ServiceMessages)
                .HasForeignKey(d => d.ServiceMessageTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceMessage_ServiceMessageType");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ServiceMessage> entity);
}
