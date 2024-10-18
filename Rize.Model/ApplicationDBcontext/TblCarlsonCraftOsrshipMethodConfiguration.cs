using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCarlsonCraftOsrshipMethodConfiguration : IEntityTypeConfiguration<TblCarlsonCraftOsrshipMethod>
{
    public void Configure(EntityTypeBuilder<TblCarlsonCraftOsrshipMethod> entity)
    {
        entity.HasKey(e => e.CarCraOsrShiMetShipMethodId);

        entity.ToTable("tblCarlsonCraftOSRShipMethods");

        entity.Property(e => e.CarCraOsrShiMetShipMethodId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CarCraOsrShiMet_ShipMethodID");
        entity.Property(e => e.CarCraOsrShiMetShipMethodDescription)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("CarCraOsrShiMet_ShipMethodDescription");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCarlsonCraftOsrshipMethod> entity);
}
