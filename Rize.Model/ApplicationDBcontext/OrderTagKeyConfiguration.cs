using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderTagKeyConfiguration : IEntityTypeConfiguration<OrderTagKey>
{
    public void Configure(EntityTypeBuilder<OrderTagKey> entity)
    {
        entity.HasKey(e => e.TagId).HasName("PK__OrderTag__657CF9AC2CA467FA");

        entity.ToTable("OrderTagKey");

        entity.Property(e => e.DisplayName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.TagCode)
                .HasMaxLength(5)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderTagKey> entity);
}
