using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PageDesignAreaConfiguration : IEntityTypeConfiguration<PageDesignArea>
{
    public void Configure(EntityTypeBuilder<PageDesignArea> entity)
    {
        entity.ToTable("PageDesignArea");

        entity.Property(e => e.PageDesignAreaId)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.DesignAreaName)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PageDesignArea> entity);
}
