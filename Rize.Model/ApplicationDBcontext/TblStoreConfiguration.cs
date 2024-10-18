using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblStoreConfiguration : IEntityTypeConfiguration<Store>
{
    public void Configure(EntityTypeBuilder<Store> entity)
    {
        entity.HasKey(e => e.StoreID).HasName("tblStores_PK");

        entity.ToTable("tblStores");

        entity.Property(e => e.StoreID).HasColumnName("Sto__StoreID");
        entity.Property(e => e.AllowAop)
                .HasDefaultValue(true)
                .HasColumnName("AllowAOP");
        entity.Property(e => e.BillingEmail)
                .HasMaxLength(48)
                .IsUnicode(false);
        entity.Property(e => e.BusinessUnit)
                .HasMaxLength(10)
                .IsUnicode(false);
        entity.Property(e => e.ClientCode)
                .HasMaxLength(10)
                .IsUnicode(false);
        entity.Property(e => e.EndDate).HasColumnType("datetime");
        entity.Property(e => e.FreightCalculator).HasDefaultValue(1);
        entity.Property(e => e.LayoutTemplate)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Notes)
                .HasMaxLength(250)
                .IsUnicode(false);
        entity.Property(e => e.StartDate).HasColumnType("datetime");
        entity.Property(e => e.StoArtworkEmail)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("Sto__ArtworkEmail");
        entity.Property(e => e.StoCardDetailPageMetaTagDescription)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("Sto__CardDetailPageMetaTagDescription");
        entity.Property(e => e.StoCardDetailPageMetaTagKeywords)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("Sto__CardDetailPageMetaTagKeywords");
        entity.Property(e => e.StoCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Sto__Code");
        entity.Property(e => e.StoCreditCardTransactionDescription)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("Sto__CreditCardTransactionDescription");
        entity.Property(e => e.StoDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Sto__Description");
        entity.Property(e => e.StoDomain)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("Sto__Domain");
        entity.Property(e => e.StoFax1)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Sto__Fax_1");
        entity.Property(e => e.StoGreetingCardDefaultQuantity).HasColumnName("Sto__GreetingCardDefaultQuantity");
        entity.Property(e => e.StoNameForWebPageTitles)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Sto__NameForWebPageTitles");
        entity.Property(e => e.StoOrderEmail)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("Sto__OrderEmail");

        entity.Property(e => e.StoOrderNumberPrefixLetter)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Sto__OrderNumberPrefixLetter");


        entity.Property(e => e.StoPhone1)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Sto__Phone_1");
        entity.Property(e => e.StoShippingEmail)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("Sto__ShippingEmail");
        entity.Property(e => e.StoStockEmail)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("Sto__StockEmail");
        entity.Property(e => e.StoSupportEmail)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("Sto__SupportEmail");
        entity.Property(e => e.StoreClosingMessage)
                .HasMaxLength(4048)
                .IsUnicode(false);
        entity.Property(e => e.YearlyOrderReminderEmail)
                .HasMaxLength(48)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Store> entity);
}
