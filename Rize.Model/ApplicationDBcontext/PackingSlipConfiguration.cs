using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PackingSlipConfiguration : IEntityTypeConfiguration<PackingSlip>
{
    public void Configure(EntityTypeBuilder<PackingSlip> entity)
    {
        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");
        entity.Property(e => e.PackingSlipXml)
                .HasColumnType("xml")
                .HasColumnName("PackingSlipXML");
        entity.Property(e => e.PlateErrorMessage)
                .HasMaxLength(1024)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PackingSlip> entity);
}
