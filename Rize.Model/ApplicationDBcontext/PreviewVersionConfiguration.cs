using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PreviewVersionConfiguration : IEntityTypeConfiguration<PreviewVersion>
{
    public void Configure(EntityTypeBuilder<PreviewVersion> entity)
    {
        entity.ToTable("PreviewVersion");

        entity.Property(e => e.PreviewVersionName)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PreviewVersion> entity);
}
