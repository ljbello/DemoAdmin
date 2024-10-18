using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class StoreConfigConfiguration : IEntityTypeConfiguration<StoreConfig>
{
    public void Configure(EntityTypeBuilder<StoreConfig> entity)
    {
        entity.HasKey(e => new { e.StoreId, e.Key }).HasName("PK__StoreCon__A7C311296BB973CB");

        entity.ToTable("StoreConfig");

        entity.Property(e => e.Key)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.ModifiedBy).HasDefaultValue(1);
        entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Value).HasMaxLength(500);

        entity.HasOne(d => d.Store).WithMany(p => p.StoreConfigs)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StoreConfig_Store");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<StoreConfig> entity);
}
