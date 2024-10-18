using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CustomerUsedUploadConfiguration : IEntityTypeConfiguration<CustomerUsedUpload>
{
    public void Configure(EntityTypeBuilder<CustomerUsedUpload> entity)
    {
        entity.ToTable("CustomerUsedUpload");

        entity.HasIndex(e => e.SavedProjectId, "IX_CustomerUpload_SavedProjectId");

        entity.HasIndex(e => e.OrderLineId, "IX_CustomerUsedUpload_OrderlineId");

        entity.Property(e => e.CustomerUsedUploadId).HasColumnName("CustomerUsedUploadID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ImageName).HasMaxLength(500);
        entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");
        entity.Property(e => e.SavedProjectId).HasColumnName("SavedProjectID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CustomerUsedUpload> entity);
}
