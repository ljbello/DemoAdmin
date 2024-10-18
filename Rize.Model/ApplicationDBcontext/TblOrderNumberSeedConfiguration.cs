using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderNumberSeedConfiguration : IEntityTypeConfiguration<TblOrderNumberSeed>
{
    public void Configure(EntityTypeBuilder<TblOrderNumberSeed> entity)
    {
        entity.HasKey(e => e.OrdNumSeeOrderNumberSeedId);

        entity.ToTable("tblOrderNumberSeeds");

        entity.Property(e => e.OrdNumSeeOrderNumberSeedId).HasColumnName("OrdNumSee__OrderNumberSeedID");
        entity.Property(e => e.OrdNumSeeDateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("OrdNumSee__DateCreated");
        entity.Property(e => e.StoStoreId)
                .HasDefaultValue(1)
                .HasColumnName("Sto__StoreID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderNumberSeed> entity);
}
