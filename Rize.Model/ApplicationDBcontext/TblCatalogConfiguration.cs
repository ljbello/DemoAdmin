using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCatalogConfiguration : IEntityTypeConfiguration<TblCatalog>
{
    public void Configure(EntityTypeBuilder<TblCatalog> entity)
    {
        entity.HasKey(e => e.CatCatalogId).HasName("tblCatalogs_PK");

        entity.ToTable("tblCatalogs");

        entity.Property(e => e.CatCatalogId).HasColumnName("Cat__CatalogID");
        entity.Property(e => e.CatCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Cat__Code");
        entity.Property(e => e.CatDisplaySequence).HasColumnName("Cat__DisplaySequence");
        entity.Property(e => e.CatSearchPrefix)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Cat__SearchPrefix");
        entity.Property(e => e.CatTitle)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Cat__Title");
        entity.Property(e => e.EndDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ImageName).HasMaxLength(100);
        entity.Property(e => e.ModifiedBy).HasDefaultValue(1);
        entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.StartDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.StoreId).HasDefaultValue(1);

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblCatalogs)
                .HasForeignKey(d => d.ModifiedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCatalogs_tblUsers");

        entity.HasOne(d => d.Store).WithMany(p => p.TblCatalogs)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCatalogs_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCatalog> entity);
}
