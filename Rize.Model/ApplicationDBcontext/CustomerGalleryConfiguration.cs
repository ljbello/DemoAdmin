using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CustomerGalleryConfiguration : IEntityTypeConfiguration<CustomerGallery>
{
    public void Configure(EntityTypeBuilder<CustomerGallery> entity)
    {
        entity.ToTable("CustomerGallery");

        entity.HasIndex(e => new { e.CustomerLoginId, e.CustomerArtworkGuidId }, "CustomerGallery_IX1");

        entity.HasIndex(e => e.CustomerArtworkGuidId, "CustomerGallery_IX2");

        entity.HasIndex(e => e.Id, "IX_CustomerGallery_ID");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

        entity.HasOne(d => d.CustomerLogin).WithMany(p => p.CustomerGalleries)
                .HasForeignKey(d => d.CustomerLoginId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerGallery_CustomerLogins");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CustomerGallery> entity);
}
