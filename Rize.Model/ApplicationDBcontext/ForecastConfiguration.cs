using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ForecastConfiguration : IEntityTypeConfiguration<Forecast>
{
    public void Configure(EntityTypeBuilder<Forecast> entity)
    {
        entity.HasKey(e => new { e.ForecastMonth, e.StoreId });

        entity.ToTable("Forecast");

        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.ForecastAmount).HasColumnType("money");
        entity.Property(e => e.InsertDate).HasColumnType("datetime");
        entity.Property(e => e.UpdateDate).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Forecast> entity);
}
