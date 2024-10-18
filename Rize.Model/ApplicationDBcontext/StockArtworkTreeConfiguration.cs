using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class StockArtworkTreeConfiguration : IEntityTypeConfiguration<StockArtworkTree>
{
    public void Configure(EntityTypeBuilder<StockArtworkTree> entity)
    {
        entity.ToTable("StockArtworkTree");

        entity.Property(e => e.StockArtworkTreeId).HasColumnName("StockArtworkTreeID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
        entity.Property(e => e.ParentId).HasColumnName("ParentID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<StockArtworkTree> entity);
}
