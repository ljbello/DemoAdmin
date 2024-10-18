using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderLineLayoutAreaCustomizationConfiguration : IEntityTypeConfiguration<TblOrderLineLayoutAreaCustomization>
{
    public void Configure(EntityTypeBuilder<TblOrderLineLayoutAreaCustomization> entity)
    {
        entity.HasKey(e => e.OrdLinLayAreCusOrderLineLayoutAreaCustomizationId);

        entity.ToTable("tblOrderLineLayoutAreaCustomizations", tb => tb.HasTrigger("tblOrderLineLayoutAreaCustomizations_Update"));

        entity.HasIndex(e => e.OrdLinOrderLineId, "_dta_index_tblOrderLineLayoutAreaCustomizat_7_179348995__K2_4").HasFillFactor(95);

        entity.Property(e => e.OrdLinLayAreCusOrderLineLayoutAreaCustomizationId).HasColumnName("OrdLinLayAreCus__OrderLineLayoutAreaCustomizationID");
        entity.Property(e => e.LayAreLayoutAreaId).HasColumnName("LayAre__LayoutAreaID");
        entity.Property(e => e.OrdLinLayAreCusImprintType).HasColumnName("OrdLinLayAreCus__ImprintType");
        entity.Property(e => e.OrdLinLayAreCusXml)
                .IsUnicode(false)
                .HasColumnName("OrdLinLayAreCus__xml");
        entity.Property(e => e.OrdLinOrderLineId).HasColumnName("OrdLin__OrderLineID");

        entity.HasOne(d => d.LayAreLayoutArea).WithMany(p => p.TblOrderLineLayoutAreaCustomizations)
                .HasForeignKey(d => d.LayAreLayoutAreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblOrderLineLayoutAreaCustomizations_tblLayoutAreas");

        entity.HasOne(d => d.OrdLinOrderLine).WithMany(p => p.TblOrderLineLayoutAreaCustomizations)
                .HasForeignKey(d => d.OrdLinOrderLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblOrderLineLayoutAreaCustomizations_tblOrderLines");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderLineLayoutAreaCustomization> entity);
}
