using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class StoreFontConfiguration : IEntityTypeConfiguration<StoreFont>
{
    public void Configure(EntityTypeBuilder<StoreFont> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__StoreFon__3214EC078EC28DCA");

        entity.ToTable("StoreFont");

        entity.Property(e => e.Active).HasDefaultValue(true);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        entity.HasOne(d => d.Font).WithMany(p => p.StoreFonts)
                .HasForeignKey(d => d.FontId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StoreFont_tblTypestyles");

        entity.HasOne(d => d.Store).WithMany(p => p.StoreFonts)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StoreFont_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<StoreFont> entity);
}
