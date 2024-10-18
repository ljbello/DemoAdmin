using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CustomerArtworkCodeMappingConfiguration : IEntityTypeConfiguration<CustomerArtworkCodeMapping>
{
    public void Configure(EntityTypeBuilder<CustomerArtworkCodeMapping> entity)
    {
        entity.HasKey(e => e.CustomerArtworkdId);

        entity.ToTable("CustomerArtworkCodeMapping");

        entity.Property(e => e.CustomerArtworkdId)
                .ValueGeneratedNever()
                .HasColumnName("CustomerArtworkdID");
        entity.Property(e => e.Code)
                .HasMaxLength(7)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CustomerArtworkCodeMapping> entity);
}
