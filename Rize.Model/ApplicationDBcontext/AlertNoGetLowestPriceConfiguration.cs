using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AlertNoGetLowestPriceConfiguration : IEntityTypeConfiguration<AlertNoGetLowestPrice>
{
    public void Configure(EntityTypeBuilder<AlertNoGetLowestPrice> entity)
    {
        entity
                .HasNoKey()
                .ToTable("AlertNoGetLowestPrice");

        entity.Property(e => e.AlertTime).HasColumnType("datetime");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AlertNoGetLowestPrice> entity);
}
