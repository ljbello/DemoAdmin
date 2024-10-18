using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ViewPaperStockFinishConfiguration : IEntityTypeConfiguration<ViewPaperStockFinish>
{
    public void Configure(EntityTypeBuilder<ViewPaperStockFinish> entity)
    {
        entity
                .HasNoKey()
                .ToView("viewPaperStockFinishes");

        entity.Property(e => e.CreatedBy)
                .HasMaxLength(65)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.Description).HasMaxLength(800);
        entity.Property(e => e.Disclaimer).HasMaxLength(800);
        entity.Property(e => e.DisplayName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ImageName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.InternalName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ModifiedBy)
                .HasMaxLength(65)
                .IsUnicode(false);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.PaperFinishName).HasMaxLength(50);
        entity.Property(e => e.PaperStockImage)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.SupplierPaperColorCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.SupplierPaperFinishCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.SupplierPaperWeightCode)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ViewPaperStockFinish> entity);
}
