using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PopularZipCodeConfiguration : IEntityTypeConfiguration<PopularZipCode>
{
    public void Configure(EntityTypeBuilder<PopularZipCode> entity)
    {
        entity.HasNoKey();

        entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID");
        entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ZipCode)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PopularZipCode> entity);
}
