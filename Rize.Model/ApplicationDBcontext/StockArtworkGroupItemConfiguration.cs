using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class StockArtworkGroupItemConfiguration : IEntityTypeConfiguration<StockArtworkGroupItem>
{
    public void Configure(EntityTypeBuilder<StockArtworkGroupItem> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__StockArt__3214EC075B40D9F5");

        entity.ToTable("StockArtworkGroupItem");

        entity.Property(e => e.CreatedBy).HasDefaultValue(1);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.SortIndex).HasDefaultValue(1);
        entity.Property(e => e.StockArtworkFilePath)
                .HasMaxLength(255)
                .IsUnicode(false);

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StockArtworkGroupItems)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockArtworkGroupItem_tblUsers");

        entity.HasOne(d => d.Group).WithMany(p => p.StockArtworkGroupItems)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockArtworkGroupItem_StockArtworkGroup");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<StockArtworkGroupItem> entity);
}
