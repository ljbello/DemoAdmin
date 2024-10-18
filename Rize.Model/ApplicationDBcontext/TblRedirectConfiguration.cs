using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblRedirectConfiguration : IEntityTypeConfiguration<TblRedirect>
{
    public void Configure(EntityTypeBuilder<TblRedirect> entity)
    {
        entity.HasKey(e => e.RedRedirectId);

        entity.ToTable("tblRedirects");

        entity.HasIndex(e => e.RedSourceUrl, "tblRedirects_IX1");

        entity.HasIndex(e => new { e.StoStoreId, e.RedSourceUrl }, "tblRedirects_IX2");

        entity.HasIndex(e => new { e.StoStoreId, e.RedEffectiveDate }, "tblRedirects_IX3");

        entity.HasIndex(e => new { e.StoStoreId, e.RedDestinationUrl }, "tblRedirects_IX4");

        entity.Property(e => e.RedRedirectId).HasColumnName("Red__RedirectId");
        entity.Property(e => e.CreatedBy).HasDefaultValue(1);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.RedDestinationUrl)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("Red__DestinationUrl");
        entity.Property(e => e.RedEffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Red__EffectiveDate");
        entity.Property(e => e.RedEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Red__EndDate");
        entity.Property(e => e.RedRedirectType).HasColumnName("Red__RedirectType");
        entity.Property(e => e.RedSourceUrl)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("Red__SourceUrl");
        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreId");

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblRedirectCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblRedirects_tblUsers_Createdby");

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblRedirectModifiedByNavigations).HasForeignKey(d => d.ModifiedBy);

        entity.HasOne(d => d.StoStore).WithMany(p => p.TblRedirects)
                .HasForeignKey(d => d.StoStoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblRedirects_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblRedirect> entity);
}
