using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class BvfeedEntryConfiguration : IEntityTypeConfiguration<BvfeedEntry>
{
    public void Configure(EntityTypeBuilder<BvfeedEntry> entity)
    {
        entity.ToTable("BVFeedEntry");

        entity.HasIndex(e => new { e.BvfeedEntryId, e.EntryTypeId }, "BVFeedEntry_IX1");

        entity.HasIndex(e => new { e.StoreId, e.Rating }, "BVFeedEntry_IX2");

        entity.HasIndex(e => e.CustomerLoginId, "BVFeedEntry_IX3");

        entity.HasIndex(e => e.ProductId, "IX_BVFeedEntry_ProductID").HasFillFactor(100);

        entity.Property(e => e.BvfeedEntryId).HasColumnName("BVFeedEntryId");
        entity.Property(e => e.Approved).HasDefaultValue(true);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.CustomerLoginId).HasColumnName("CustomerLoginID");
        entity.Property(e => e.EntryText).HasColumnType("text");
        entity.Property(e => e.InternalNotes).HasMaxLength(800);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.OrderId).HasColumnName("OrderID");
        entity.Property(e => e.ProductPhoto).HasColumnType("image");
        entity.Property(e => e.StoreId).HasDefaultValue(1);
        entity.Property(e => e.SubmissionTime).HasColumnType("datetime");
        entity.Property(e => e.Title)
                .HasMaxLength(600)
                .IsUnicode(false);
        entity.Property(e => e.UserProfileName)
                .HasMaxLength(200)
                .IsUnicode(false);

        entity.HasOne(d => d.CustomerLogin).WithMany(p => p.BvfeedEntries)
                .HasForeignKey(d => d.CustomerLoginId)
                .HasConstraintName("FK_BVFeedEntry_CustomerLogins");

        entity.HasOne(d => d.Product).WithMany(p => p.BvfeedEntries)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BVFeedEntry_tblProducts");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<BvfeedEntry> entity);
}
