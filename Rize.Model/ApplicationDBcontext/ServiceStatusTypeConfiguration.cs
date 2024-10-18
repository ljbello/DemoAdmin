using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ServiceStatusTypeConfiguration : IEntityTypeConfiguration<ServiceStatusType>
{
    public void Configure(EntityTypeBuilder<ServiceStatusType> entity)
    {
        entity.ToTable("ServiceStatusType");

        entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        entity.Property(e => e.Created).HasColumnType("datetime");
        entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ServiceStatusType> entity);
}
