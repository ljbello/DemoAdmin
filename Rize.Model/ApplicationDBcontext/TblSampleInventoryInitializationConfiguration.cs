using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblSampleInventoryInitializationConfiguration : IEntityTypeConfiguration<TblSampleInventoryInitialization>
{
    public void Configure(EntityTypeBuilder<TblSampleInventoryInitialization> entity)
    {
        entity.HasKey(e => e.SamInvIniSampleInventoryInitializationId);

        entity.ToTable("tblSampleInventoryInitialization");

        entity.Property(e => e.SamInvIniSampleInventoryInitializationId).HasColumnName("SamInvIni__SampleInventoryInitializationID");
        entity.Property(e => e.SamInvIniInitializationInsteadOfUpdate)
                .HasDefaultValue(true)
                .HasColumnName("SamInvIni__InitializationInsteadOfUpdate");
        entity.Property(e => e.SamInvIniNumberOfMatchesFound).HasColumnName("SamInvIni__NumberOfMatchesFound");
        entity.Property(e => e.SamInvIniProposedManufacturerProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("SamInvIni__ProposedManufacturerProductNumber");
        entity.Property(e => e.SamInvIniProposedQuantity).HasColumnName("SamInvIni__ProposedQuantity");
        entity.Property(e => e.SamInvIniProposedSupplierId).HasColumnName("SamInvIni__ProposedSupplierID");
        entity.Property(e => e.SamInvIniProposedSupplierProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("SamInvIni__ProposedSupplierProductNumber");
        entity.Property(e => e.SamInvIniTimeStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SamInvIni__TimeStamp");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblSampleInventoryInitialization> entity);
}
