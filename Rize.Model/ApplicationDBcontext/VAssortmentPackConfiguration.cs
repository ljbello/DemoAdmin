using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VAssortmentPackConfiguration : IEntityTypeConfiguration<VAssortmentPack>
{
    public void Configure(EntityTypeBuilder<VAssortmentPack> entity)
    {
        entity
                .HasNoKey()
                .ToView("vAssortmentPack");

        entity.Property(e => e.ActiveDate).HasColumnType("datetime");
        entity.Property(e => e.AdditionalKeywords)
                .HasMaxLength(300)
                .IsUnicode(false);
        entity.Property(e => e.DepartmentName)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.DepartmentUrl)
                .HasMaxLength(500)
                .IsUnicode(false);
        entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
        entity.Property(e => e.EntityCreated).HasColumnType("datetime");
        entity.Property(e => e.ManufacturerProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.MetaDescription)
                .HasMaxLength(800)
                .IsUnicode(false);
        entity.Property(e => e.MetaKeywords)
                .HasMaxLength(500)
                .IsUnicode(false);
        entity.Property(e => e.MetaTitle)
                .HasMaxLength(200)
                .IsUnicode(false);
        entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.PackUrl)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Price).HasColumnType("money");
        entity.Property(e => e.ProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.ProductStatusId).HasColumnName("ProductStatusID");
        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");
        entity.Property(e => e.SupplierProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VAssortmentPack> entity);
}
