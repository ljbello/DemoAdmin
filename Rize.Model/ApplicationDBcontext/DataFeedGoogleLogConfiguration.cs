using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DataFeedGoogleLogConfiguration : IEntityTypeConfiguration<DataFeedGoogleLog>
{
    public void Configure(EntityTypeBuilder<DataFeedGoogleLog> entity)
    {
        entity
                .HasNoKey()
                .ToTable("DataFeedGoogleLog");

        entity.HasIndex(e => new { e.StoreId, e.ChangedRecord }, "DataFeedGoogle_IX2");

        entity.HasIndex(e => new { e.StoreId, e.ProcessStatus }, "DataFeedGoogle_IX3");

        entity.Property(e => e.InsertDate).HasColumnType("datetime");
        entity.Property(e => e.ProcessStatus)
                .HasMaxLength(1)
                .IsUnicode(false);
        entity.Property(e => e.ProductId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ProductID");
        entity.Property(e => e.ProductType)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("product_type");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DataFeedGoogleLog> entity);
}
