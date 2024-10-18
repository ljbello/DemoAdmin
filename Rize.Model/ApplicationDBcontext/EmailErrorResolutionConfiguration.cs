using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class EmailErrorResolutionConfiguration : IEntityTypeConfiguration<EmailErrorResolution>
{
    public void Configure(EntityTypeBuilder<EmailErrorResolution> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__EmailErr__3214EC270C9FFFE1");

        entity.ToTable("EmailErrorResolution");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.ErrorContainText).HasMaxLength(100);
        entity.Property(e => e.ResolutionText).HasMaxLength(400);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<EmailErrorResolution> entity);
}
