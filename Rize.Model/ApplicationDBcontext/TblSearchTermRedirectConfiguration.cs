using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblSearchTermRedirectConfiguration : IEntityTypeConfiguration<TblSearchTermRedirect>
{
    public void Configure(EntityTypeBuilder<TblSearchTermRedirect> entity)
    {
        entity.HasKey(e => e.SeaTerRedSearchTermRedirectId).HasName("tblSearchTermRedirects_PK");

        entity.ToTable("tblSearchTermRedirects");

        entity.Property(e => e.SeaTerRedSearchTermRedirectId).HasColumnName("SeaTerRed__SearchTermRedirectID");
        entity.Property(e => e.SeaTerRedDestinationPage)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("SeaTerRed__DestinationPage");
        entity.Property(e => e.SeaTerRedDestinationPageIsCompleteUrl).HasColumnName("SeaTerRed__DestinationPageIsCompleteURL");
        entity.Property(e => e.SeaTerRedSearchTerm)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SeaTerRed__SearchTerm");
        entity.Property(e => e.SeaTerRedSearchTermSynonyms)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("SeaTerRed__SearchTermSynonyms");
        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");

        entity.HasOne(d => d.StoStore).WithMany(p => p.TblSearchTermRedirects)
                .HasForeignKey(d => d.StoStoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSearchTermRedirects_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblSearchTermRedirect> entity);
}
