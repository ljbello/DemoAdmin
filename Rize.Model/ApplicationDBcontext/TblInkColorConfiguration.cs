using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblInkColorConfiguration : IEntityTypeConfiguration<TblInkColor>
{
    public void Configure(EntityTypeBuilder<TblInkColor> entity)
    {
        entity.HasKey(e => e.InkColInkColorId).HasName("tblInkColors_PK");

        entity.ToTable("tblInkColors");

        entity.HasIndex(e => e.InkColType, "_dta_index_tblInkColors_6_1079700386__K16_1_3_5_11_13_14_15");

        entity.Property(e => e.InkColInkColorId).HasColumnName("InkCol__InkColorID");
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.InkColBlue).HasColumnName("InkCol__Blue");
        entity.Property(e => e.InkColGreen).HasColumnName("InkCol__Green");
        entity.Property(e => e.InkColIcsmcolor)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("InkCol__ICSMColor");
        entity.Property(e => e.InkColIsFoil).HasColumnName("InkCol__IsFoil");
        entity.Property(e => e.InkColName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InkCol__Name");
        entity.Property(e => e.InkColPmscode)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("InkCol__PMSCode");
        entity.Property(e => e.InkColRed).HasColumnName("InkCol__Red");
        entity.Property(e => e.InkColRgb)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("InkCol__RGB");
        entity.Property(e => e.InkColType)
                .HasDefaultValue((short)1)
                .HasColumnName("InkCol__Type");
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.ProTypProductTypeId).HasColumnName("ProTyp__ProductTypeID");

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblInkColors)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_tblInkColors_tblUsers");

        entity.HasOne(d => d.ProTypProductType).WithMany(p => p.TblInkColors)
                .HasForeignKey(d => d.ProTypProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblInkColors_ProductType");

        entity.HasMany(d => d.ProProducts).WithMany(p => p.InkColInkColors)
            .UsingEntity<Dictionary<string, object>>(
                "TblProductInkColor",
                r => r.HasOne<TblProduct>().WithMany()
                        .HasForeignKey("ProProductId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_tblProductInkColors_tblProducts"),
                l => l.HasOne<TblInkColor>().WithMany()
                        .HasForeignKey("InkColInkColorId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("tblInkColors_tblProductInkColors_FK1"),
                j =>
                {
                    j.HasKey("InkColInkColorId", "ProProductId").HasName("tblProductInkColors_PK");
                    j.ToTable("tblProductInkColors");
                    j.HasIndex(new[] { "ProProductId" }, "index_1");
                   j.IndexerProperty<int>("InkColInkColorId").HasColumnName("InkCol__InkColorID");
                   j.IndexerProperty<int>("ProProductId").HasColumnName("Pro__ProductID");
            });

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblInkColor> entity);
}
