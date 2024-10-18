using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AutoProductImportLogConfiguration : IEntityTypeConfiguration<AutoProductImportLog>
{
    public void Configure(EntityTypeBuilder<AutoProductImportLog> entity)
    {
        entity
                .HasNoKey()
                .ToTable("AutoProductImportLog");

        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.Message).IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AutoProductImportLog> entity);
}
