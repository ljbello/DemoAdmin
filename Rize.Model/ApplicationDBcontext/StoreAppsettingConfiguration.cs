using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class StoreAppsettingConfiguration : IEntityTypeConfiguration<StoreAppsetting>
{
    public void Configure(EntityTypeBuilder<StoreAppsetting> entity)
    {
        entity.Property(e => e.AdminwebUrl)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AdminwebURL");
        entity.Property(e => e.HostName)
                .HasMaxLength(150)
                .IsUnicode(false);
        entity.Property(e => e.HubPath)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ImageHandlerUrl)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ImageHandlerURL");
        entity.Property(e => e.PreviewUrl)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PreviewURL");
        entity.Property(e => e.ProductImageHandlerUrl)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProductImageHandlerURL");
        entity.Property(e => e.SsoacceptBackdoor).HasColumnName("SSOAcceptBackdoor");
        entity.Property(e => e.SsoapplyAuthWideStoreLevel).HasColumnName("SSOApplyAuthWideStoreLevel");
        entity.Property(e => e.SsobackDoorGuid)
                .HasMaxLength(50)
                .HasColumnName("SSOBackDoorGUID");
        entity.Property(e => e.SsobackdoorAuthUrl).HasColumnName("SSOBackdoorAuthUrl");
        entity.Property(e => e.SsobackdoorLogoutUrl).HasColumnName("SSOBackdoorLogoutUrl");
        entity.Property(e => e.Ssoenable).HasColumnName("SSOEnable");
        entity.Property(e => e.StoreName)
                .HasMaxLength(50)
                .IsUnicode(false);

        entity.HasOne(d => d.Store).WithMany(p => p.StoreAppsettings)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StoreAppsettings_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<StoreAppsetting> entity);
}
