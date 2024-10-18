using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class StockArtworkGroupConfiguration : IEntityTypeConfiguration<StockArtworkGroup>
{
    public void Configure(EntityTypeBuilder<StockArtworkGroup> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__StockArt__3214EC07F515281A");

        entity.ToTable("StockArtworkGroup");

        entity.Property(e => e.CreatedBy).HasDefaultValue(1);
        entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");
        entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StockArtworkGroups)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockArtworkGroup_tblUsers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<StockArtworkGroup> entity);
}
