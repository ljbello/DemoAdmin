using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ImageTypeConfiguration : IEntityTypeConfiguration<ImageType>
{
    public void Configure(EntityTypeBuilder<ImageType> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__ImageTyp__3214EC076657D7B9");

        entity.ToTable("ImageType");

        entity.Property(e => e.Id).ValueGeneratedNever();
        entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ImageType> entity);
}
