using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SsosettingConfiguration : IEntityTypeConfiguration<Ssosetting>
{
    public void Configure(EntityTypeBuilder<Ssosetting> entity)
    {
        entity.ToTable("SSOSettings");

        entity.Property(e => e.AuthUrl).HasColumnName("AuthURL");
        entity.Property(e => e.LogoutUrl).HasColumnName("LogoutURL");
        entity.Property(e => e.Ssotype).HasColumnName("SSOType");

        entity.HasOne(d => d.StoreAppSetting).WithMany(p => p.Ssosettings)
                .HasForeignKey(d => d.StoreAppSettingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SSOSettings_StoreAppsettings");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Ssosetting> entity);
}
