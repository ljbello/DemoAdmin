using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCardDetailInitializationConfiguration : IEntityTypeConfiguration<TblCardDetailInitialization>
{
    public void Configure(EntityTypeBuilder<TblCardDetailInitialization> entity)
    {
        entity.HasKey(e => e.CarDetIniCardDetailInitializationId);

        entity.ToTable("tblCardDetailInitialization");

        entity.Property(e => e.CarDetIniCardDetailInitializationId).HasColumnName("CarDetIni__CardDetailInitializationID");
        entity.Property(e => e.CarDetIniNumberOfMatches).HasColumnName("CarDetIni__NumberOfMatches");
        entity.Property(e => e.CarDetIniProposedProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("CarDetIni__ProposedProductNumber");
        entity.Property(e => e.CarDetIniTimeStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CarDetIni__TimeStamp");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCardDetailInitialization> entity);
}
