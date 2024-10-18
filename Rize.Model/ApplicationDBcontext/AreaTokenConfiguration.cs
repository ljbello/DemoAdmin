using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AreaTokenConfiguration : IEntityTypeConfiguration<AreaToken>
{
    public void Configure(EntityTypeBuilder<AreaToken> entity)
    {
        entity.HasKey(e => e.Token);

        entity.ToTable("AreaToken");

        entity.Property(e => e.Token)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Value).HasMaxLength(256);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AreaToken> entity);
}
