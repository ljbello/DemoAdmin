using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DomoIpexclusionConfiguration : IEntityTypeConfiguration<DomoIpexclusion>
{
    public void Configure(EntityTypeBuilder<DomoIpexclusion> entity)
    {
        entity
                .HasNoKey()
                .ToTable("DomoIPExclusion");

        entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Ipaddress)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IPAddress");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DomoIpexclusion> entity);
}
