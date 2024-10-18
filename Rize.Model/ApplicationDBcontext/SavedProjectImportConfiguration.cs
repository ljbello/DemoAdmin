using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SavedProjectImportConfiguration : IEntityTypeConfiguration<SavedProjectImport>
{
    public void Configure(EntityTypeBuilder<SavedProjectImport> entity)
    {
        entity.HasKey(e => e.SavedProjectId);

        entity.ToTable("SavedProjectImport");

        entity.Property(e => e.SavedProjectId).ValueGeneratedNever();
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.CustomerEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SavedProjectImport> entity);
}
