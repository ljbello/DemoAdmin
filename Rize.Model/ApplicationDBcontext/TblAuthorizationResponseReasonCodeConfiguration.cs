using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblAuthorizationResponseReasonCodeConfiguration : IEntityTypeConfiguration<TblAuthorizationResponseReasonCode>
{
    public void Configure(EntityTypeBuilder<TblAuthorizationResponseReasonCode> entity)
    {
        entity.HasKey(e => e.AutResReaCodResponseReasonCode);

        entity.ToTable("tblAuthorizationResponseReasonCodes");

        entity.Property(e => e.AutResReaCodResponseReasonCode)
                .ValueGeneratedNever()
                .HasColumnName("AutResReaCod__ResponseReasonCode");
        entity.Property(e => e.AutResCodResponseCode).HasColumnName("AutResCod__ResponseCode");
        entity.Property(e => e.AutResReaCodDescription)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("AutResReaCod__Description");
        entity.Property(e => e.AutResReaCodNotes)
                .HasMaxLength(4096)
                .IsUnicode(false)
                .HasColumnName("AutResReaCod__Notes");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblAuthorizationResponseReasonCode> entity);
}
