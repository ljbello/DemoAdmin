using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PaperStockFinishConfiguration : IEntityTypeConfiguration<PaperStockFinish>
{
    public void Configure(EntityTypeBuilder<PaperStockFinish> entity)
    {
        entity.ToTable("PaperStockFinish");

        entity.HasIndex(e => new { e.PaperStockFinishId, e.PaperFinishId }, "PaperStockFinish_IX1");

        entity.HasIndex(e => new { e.PaperStockId, e.PaperFinishId }, "PaperStockFinish_IX2");

        entity.Property(e => e.Active).HasDefaultValue(true);
        entity.Property(e => e.CreatedBy).HasDefaultValue(1);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
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
        entity.Property(e => e.LogoSetType)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
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

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.PaperStockFinishCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PaperStockFinish_UserCreated");

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.PaperStockFinishModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_PaperStockFinish_UserModified");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PaperStockFinish> entity);
}
