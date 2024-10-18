using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblProductsDtpinvalidConfiguration : IEntityTypeConfiguration<TblProductsDtpinvalid>
{
    public void Configure(EntityTypeBuilder<TblProductsDtpinvalid> entity)
    {
        entity.HasKey(e => e.ProProductNumber);

        entity.ToTable("tblProducts_DTPInvalid");

        entity.Property(e => e.ProProductNumber)
                .HasMaxLength(32)
                .HasColumnName("Pro__ProductNumber");
        entity.Property(e => e.ProDtpInvDateActive)
                .HasColumnType("smalldatetime")
                .HasColumnName("ProDtpInv__DateActive");
        entity.Property(e => e.ProDtpInvNotes)
                .HasMaxLength(2999)
                .IsUnicode(false)
                .HasColumnName("ProDtpInv__Notes");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblProductsDtpinvalid> entity);
}
