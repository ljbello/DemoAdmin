using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblAuthorizationResponseCodeConfiguration : IEntityTypeConfiguration<TblAuthorizationResponseCode>
{
    public void Configure(EntityTypeBuilder<TblAuthorizationResponseCode> entity)
    {
        entity.HasKey(e => e.AutResCodResponseCode);

        entity.ToTable("tblAuthorizationResponseCodes");

        entity.Property(e => e.AutResCodResponseCode)
                .ValueGeneratedNever()
                .HasColumnName("AutResCod__ResponseCode");
        entity.Property(e => e.AutResCodDescription)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("AutResCod__Description");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblAuthorizationResponseCode> entity);
}
