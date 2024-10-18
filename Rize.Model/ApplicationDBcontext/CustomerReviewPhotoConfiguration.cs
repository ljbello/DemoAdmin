using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CustomerReviewPhotoConfiguration : IEntityTypeConfiguration<CustomerReviewPhoto>
{
    public void Configure(EntityTypeBuilder<CustomerReviewPhoto> entity)
    {
        entity.HasIndex(e => new { e.EntryId, e.ImageName }, "CustomerReviewPhotos_IX1");

        entity.Property(e => e.EntryId).HasColumnName("EntryID");
        entity.Property(e => e.ImageName)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.UploadDate).HasColumnType("datetime");

        entity.HasOne(d => d.Entry).WithMany(p => p.CustomerReviewPhotos)
                .HasForeignKey(d => d.EntryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerReviewPhotos_BVFeedEntry");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CustomerReviewPhoto> entity);
}
