using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VAssortmentPackProductConfiguration : IEntityTypeConfiguration<VAssortmentPackProduct>
{
    public void Configure(EntityTypeBuilder<VAssortmentPackProduct> entity)
    {
        entity
                .HasNoKey()
                .ToView("vAssortmentPackProducts");

        entity.Property(e => e.EntityCreated).HasColumnType("datetime");
        entity.Property(e => e.EntityUpdated).HasColumnType("datetime");
        entity.Property(e => e.EnvelopeName)
                .HasMaxLength(48)
                .IsUnicode(false);
        entity.Property(e => e.FrontImage).HasMaxLength(500);
        entity.Property(e => e.Orientation)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        entity.Property(e => e.ProductName)
                .HasMaxLength(256)
                .IsUnicode(false);
        entity.Property(e => e.ProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.SizeName)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");
        entity.Property(e => e.VerseImage)
                .HasMaxLength(255)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VAssortmentPackProduct> entity);
}
