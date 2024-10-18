using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderLineLayoutAreaCustomizationsFrombackupConfiguration : IEntityTypeConfiguration<TblOrderLineLayoutAreaCustomizationsFrombackup>
{
    public void Configure(EntityTypeBuilder<TblOrderLineLayoutAreaCustomizationsFrombackup> entity)
    {
        entity
                .HasNoKey()
                .ToTable("tblOrderLineLayoutAreaCustomizations_frombackup");

        entity.Property(e => e.LayAreLayoutAreaId).HasColumnName("LayAre__LayoutAreaID");
        entity.Property(e => e.OrdLinLayAreCusImprintType).HasColumnName("OrdLinLayAreCus__ImprintType");
        entity.Property(e => e.OrdLinLayAreCusOrderLineLayoutAreaCustomizationId).HasColumnName("OrdLinLayAreCus__OrderLineLayoutAreaCustomizationID");
        entity.Property(e => e.OrdLinLayAreCusXml)
                .HasColumnType("text")
                .HasColumnName("OrdLinLayAreCus__xml");
        entity.Property(e => e.OrdLinOrderLineId).HasColumnName("OrdLin__OrderLineID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderLineLayoutAreaCustomizationsFrombackup> entity);
}
