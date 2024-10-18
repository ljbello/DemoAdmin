using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProspectDoNotMailConfiguration : IEntityTypeConfiguration<ProspectDoNotMail>
{
    public void Configure(EntityTypeBuilder<ProspectDoNotMail> entity)
    {
        entity
                .HasNoKey()
                .ToTable("ProspectDoNotMail");

        entity.Property(e => e.Address1)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.Address2)
                .HasMaxLength(64)
                .IsUnicode(false);
        entity.Property(e => e.City)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.Company)
                .HasMaxLength(128)
                .IsUnicode(false);
        entity.Property(e => e.FirstName)
                .HasMaxLength(64)
                .IsUnicode(false);
        entity.Property(e => e.LastName)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        entity.Property(e => e.Zip)
                .HasMaxLength(12)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProspectDoNotMail> entity);
}
