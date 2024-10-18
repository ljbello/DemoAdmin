using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblBasketConfiguration : IEntityTypeConfiguration<TblBasket>
{
    public void Configure(EntityTypeBuilder<TblBasket> entity)
    {
        entity.HasKey(e => e.BasBasketId).HasName("tblBasket_PK");

        entity.ToTable("tblBasket");

        entity.Property(e => e.BasBasketId).HasColumnName("Bas__BasketID");
        entity.Property(e => e.BasBrowser)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Bas__Browser");
        entity.Property(e => e.BasIpaddress)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Bas__IPAddress");
        entity.Property(e => e.BasLandingPage)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Bas__LandingPage");
        entity.Property(e => e.BasPurchasePage)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Bas__PurchasePage");
        entity.Property(e => e.BasPurchasePageReferrer)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Bas__PurchasePageReferrer");
        entity.Property(e => e.BasSearchEngine)
                .HasMaxLength(96)
                .IsUnicode(false)
                .HasColumnName("Bas__SearchEngine");
        entity.Property(e => e.BasSearchTerm)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Bas__SearchTerm");
        entity.Property(e => e.BasTimeSiteEntered)
                .HasColumnType("datetime")
                .HasColumnName("Bas__TimeSiteEntered");
        entity.Property(e => e.BasUrl)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Bas__URL");
        entity.Property(e => e.BasVisits).HasColumnName("Bas__Visits");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblBasket> entity);
}
