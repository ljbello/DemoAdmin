using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ServiceMessageTypeConfiguration : IEntityTypeConfiguration<ServiceMessageType>
{
    public void Configure(EntityTypeBuilder<ServiceMessageType> entity)
    {
        entity.ToTable("ServiceMessageType");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Created).HasColumnType("datetime");
        entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Updated).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ServiceMessageType> entity);
}
