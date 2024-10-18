using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class GetLowestPriceConfiguration : IEntityTypeConfiguration<GetLowestPrice>
{
    public void Configure(EntityTypeBuilder<GetLowestPrice> entity)
    {
        entity
                .HasNoKey()
                .ToView("GetLowestPrice");

        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductID");
        entity.Property(e => e.SalePrice).HasColumnType("money");
        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<GetLowestPrice> entity);
}
