using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class LowestPriceConfiguration : IEntityTypeConfiguration<LowestPrice>
{
    public void Configure(EntityTypeBuilder<LowestPrice> entity)
    {
        entity.HasKey(e => new { e.ProProductId, e.StoStoreId });

        entity.ToTable("LowestPrice");

        entity.HasIndex(e => e.StoStoreId, "LowestPrice_IX1");

        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductID");
        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");
        entity.Property(e => e.InsertDate).HasColumnType("datetime");
        entity.Property(e => e.SalePrice).HasColumnType("money");
        entity.Property(e => e.UpdateDate).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<LowestPrice> entity);
}
