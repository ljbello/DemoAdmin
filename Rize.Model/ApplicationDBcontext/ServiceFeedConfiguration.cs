using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ServiceFeedConfiguration : IEntityTypeConfiguration<ServiceFeed>
{
    public void Configure(EntityTypeBuilder<ServiceFeed> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK_Feed");

        entity.ToTable("ServiceFeed");

        entity.HasIndex(e => e.ServiceId, "IX_ServiceFeed").IsUnique();

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Created).HasColumnType("datetime");
        entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Path)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.RemoteAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.RemotePassword)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.RemoteUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
        entity.Property(e => e.Updated).HasColumnType("datetime");

        entity.HasOne(d => d.Service).WithOne(p => p.ServiceFeed)
                .HasForeignKey<ServiceFeed>(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceFeed_Service");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ServiceFeed> entity);
}
