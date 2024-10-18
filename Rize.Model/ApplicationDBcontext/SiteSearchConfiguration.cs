using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SiteSearchConfiguration : IEntityTypeConfiguration<SiteSearch>
{
    public void Configure(EntityTypeBuilder<SiteSearch> entity)
    {
        entity.ToTable("SiteSearch");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Keyword)
                .HasMaxLength(400)
                .IsUnicode(false);
        entity.Property(e => e.RedirectedTo).HasMaxLength(2000);
        entity.Property(e => e.ReferralUrl)
                .HasMaxLength(2000)
                .HasColumnName("ReferralURL");
        entity.Property(e => e.SearchedOn).HasColumnType("datetime");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.UserIp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UserIP");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SiteSearch> entity);
}
