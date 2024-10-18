using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblAuthorizationCardCodeConfiguration : IEntityTypeConfiguration<TblAuthorizationCardCode>
{
    public void Configure(EntityTypeBuilder<TblAuthorizationCardCode> entity)
    {
        entity.HasKey(e => e.AutCarCodCardCode);

        entity.ToTable("tblAuthorizationCardCodes");

        entity.Property(e => e.AutCarCodCardCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("AutCarCod__CardCode");
        entity.Property(e => e.AutCarCodDescription)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("AutCarCod__Description");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblAuthorizationCardCode> entity);
}
