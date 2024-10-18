using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class FaqItemConfiguration : IEntityTypeConfiguration<FaqItem>
{
    public void Configure(EntityTypeBuilder<FaqItem> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__FaqItem__3214EC07E960577F");

        entity.ToTable("FaqItem");

        entity.HasIndex(e => new { e.StoreId, e.Active, e.CategoryId }, "FaqItem_IX1");

        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.Title).HasMaxLength(100);

        entity.HasOne(d => d.Category).WithMany(p => p.FaqItems)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FaqItem_FaqCategory");

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.FaqItemCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FaqItem_UserCreated");

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.FaqItemModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_FaqItem_UserModified");

        entity.HasOne(d => d.Store).WithMany(p => p.FaqItems)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FaqItem_Store");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<FaqItem> entity);
}
