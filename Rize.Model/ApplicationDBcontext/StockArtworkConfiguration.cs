using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class StockArtworkConfiguration : IEntityTypeConfiguration<StockArtwork>
{
    public void Configure(EntityTypeBuilder<StockArtwork> entity)
    {
        entity.ToTable("StockArtwork");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Filepath)
                .HasMaxLength(255)
                .IsUnicode(false);
        entity.Property(e => e.Keywords).IsUnicode(false);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.StockArtworkFileName)
                .HasMaxLength(128)
                .IsUnicode(false);
        entity.Property(e => e.StockArtworkTreeId).HasColumnName("StockArtworkTreeID");

        entity.HasOne(d => d.StockArtworkTree).WithMany(p => p.StockArtworks)
                .HasForeignKey(d => d.StockArtworkTreeId)
                .HasConstraintName("FK_StockArtwork_StockArtworkTree");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<StockArtwork> entity);
}
