using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblPrintItemConfiguration : IEntityTypeConfiguration<TblPrintItem>
{
    public void Configure(EntityTypeBuilder<TblPrintItem> entity)
    {
        entity.HasKey(e => e.PriItePrintItemId).HasName("tblPrintItem_PK");

        entity.ToTable("tblPrintItem");

        entity.Property(e => e.PriItePrintItemId).HasColumnName("PriIte__PrintItemID");
        entity.Property(e => e.PriIteDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("PriIte__Description");

        entity.HasMany(d => d.AreAreas).WithMany(p => p.PriItePrintItems)
            .UsingEntity<Dictionary<string, object>>(
                "TblPrintItemArea",
                r => r.HasOne<TblArea>().WithMany()
                        .HasForeignKey("AreAreaId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("tblAreas_tblPrintItemAreas_FK1"),
                l => l.HasOne<TblPrintItem>().WithMany()
                        .HasForeignKey("PriItePrintItemId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("tblPrintItem_tblPrintItemAreas_FK1"),
                j =>
                {
                    j.HasKey("PriItePrintItemId", "AreAreaId").HasName("tblPrintItemAreas_PK");
                    j.ToTable("tblPrintItemAreas");
                   j.IndexerProperty<int>("PriItePrintItemId").HasColumnName("PriIte__PrintItemID");
                   j.IndexerProperty<int>("AreAreaId").HasColumnName("Are__AreaID");
            });

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblPrintItem> entity);
}
