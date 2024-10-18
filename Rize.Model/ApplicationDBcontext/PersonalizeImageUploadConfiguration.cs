using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PersonalizeImageUploadConfiguration : IEntityTypeConfiguration<PersonalizeImageUpload>
{
    public void Configure(EntityTypeBuilder<PersonalizeImageUpload> entity)
    {
        entity.HasKey(e => e.UploadId).HasName("PK_PersonalizeImageUploads");

        entity.ToTable("PersonalizeImageUpload");

        entity.HasIndex(e => e.CustomerArtworkId, "IX_PersonalizeImageUpload").HasFillFactor(100);

        entity.HasIndex(e => new { e.CustomerArtworkId, e.Visible }, "PersonalizeImageUpload_IX1");

        entity.HasIndex(e => e.ImageName, "PersonalizeImageUpload_IX2");

        entity.Property(e => e.DateUploaded)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ImageName).HasMaxLength(255);
        entity.Property(e => e.LastProcessDate).HasColumnType("datetime");
        entity.Property(e => e.Visible).HasDefaultValue(true);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PersonalizeImageUpload> entity);
}
