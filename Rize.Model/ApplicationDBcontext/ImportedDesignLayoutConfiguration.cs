using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ImportedDesignLayoutConfiguration : IEntityTypeConfiguration<ImportedDesignLayout>
{
    public void Configure(EntityTypeBuilder<ImportedDesignLayout> entity)
    {
        entity.ToTable("ImportedDesignLayout");

        entity.Property(e => e.Id).HasColumnName("ID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ImportedDesignLayout> entity);
}
