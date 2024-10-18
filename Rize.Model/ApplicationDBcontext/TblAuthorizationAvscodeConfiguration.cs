using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblAuthorizationAvscodeConfiguration : IEntityTypeConfiguration<TblAuthorizationAvscode>
{
    public void Configure(EntityTypeBuilder<TblAuthorizationAvscode> entity)
    {
        entity.HasKey(e => e.AutAvsCodAvscode);

        entity.ToTable("tblAuthorizationAVSCodes");

        entity.Property(e => e.AutAvsCodAvscode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("AutAvsCod__AVSCode");
        entity.Property(e => e.AutAvsCodDescription)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("AutAvsCod__Description");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblAuthorizationAvscode> entity);
}
