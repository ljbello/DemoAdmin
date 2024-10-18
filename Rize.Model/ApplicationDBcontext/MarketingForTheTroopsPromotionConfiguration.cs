using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class MarketingForTheTroopsPromotionConfiguration : IEntityTypeConfiguration<MarketingForTheTroopsPromotion>
{
    public void Configure(EntityTypeBuilder<MarketingForTheTroopsPromotion> entity)
    {
        entity.ToTable("Marketing_ForTheTroopsPromotion");

        entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.EmailAddress)
                .HasMaxLength(200)
                .IsUnicode(false);
        entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Message)
                .HasMaxLength(140)
                .IsUnicode(false);
        entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<MarketingForTheTroopsPromotion> entity);
}
