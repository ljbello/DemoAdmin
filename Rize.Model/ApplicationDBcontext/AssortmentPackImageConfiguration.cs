using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AssortmentPackImageConfiguration : IEntityTypeConfiguration<AssortmentPackImage>
{
    public void Configure(EntityTypeBuilder<AssortmentPackImage> entity)
    {
        entity.ToTable("AssortmentPackImage");

        entity.Property(e => e.EntityCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.EntityRank).HasDefaultValue(2147483647);
        entity.Property(e => e.EntityUpdated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.EnvelopeId).HasDefaultValue(14);
        entity.Property(e => e.FrontImage)
                .HasMaxLength(500)
                .IsUnicode(false);
        entity.Property(e => e.Orientation)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("H")
                .IsFixedLength();
        entity.Property(e => e.ProductNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.VerseImage)
                .HasMaxLength(255)
                .IsUnicode(false);

        entity.HasOne(d => d.PackProduct).WithMany(p => p.AssortmentPackImages)
                .HasForeignKey(d => d.PackProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssortmentPackImage_AssortmentPack");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AssortmentPackImage> entity);
}
