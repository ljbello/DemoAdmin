using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CatalogUnsubcribeConfiguration : IEntityTypeConfiguration<CatalogUnsubcribe>
{
    public void Configure(EntityTypeBuilder<CatalogUnsubcribe> entity)
    {
        entity.HasKey(e => e.CatalogUnsubcribeId).HasName("PK__CatalogU__F4AA825A218E260C");

        entity.ToTable("CatalogUnsubcribe");

        entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
        entity.Property(e => e.Address2)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Company)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false);
        entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.PromoCode)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.State)
                .HasMaxLength(3)
                .IsUnicode(false);
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.ZipCode)
                .HasMaxLength(15)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CatalogUnsubcribe> entity);
}
