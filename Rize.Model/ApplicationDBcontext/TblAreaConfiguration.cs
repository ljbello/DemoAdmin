using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblAreaConfiguration : IEntityTypeConfiguration<TblArea>
{
    public void Configure(EntityTypeBuilder<TblArea> entity)
    {
        entity.HasKey(e => e.AreAreaId).HasName("tblAreas_PK");

        entity.ToTable("tblAreas");

        entity.Property(e => e.AreAreaId).HasColumnName("Are__AreaID");
        entity.Property(e => e.AreCXmlAreaId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Are__cXML_AreaID");
        entity.Property(e => e.AreDescription)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Are__Description");
        entity.Property(e => e.AreIcsmAreaInfoName)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Are__ICSM_AreaInfoName");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblArea> entity);
}
