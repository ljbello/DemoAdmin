using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SampleKitRequestConfiguration : IEntityTypeConfiguration<SampleKitRequest>
{
    public void Configure(EntityTypeBuilder<SampleKitRequest> entity)
    {
        entity.ToTable("SampleKitRequest");

        entity.Property(e => e.Address1).HasMaxLength(100);
        entity.Property(e => e.Address2).HasMaxLength(100);
        entity.Property(e => e.City).HasMaxLength(100);
        entity.Property(e => e.CompanyName).HasMaxLength(200);
        entity.Property(e => e.Country).HasMaxLength(50);
        entity.Property(e => e.Email).HasMaxLength(50);
        entity.Property(e => e.FirstName).HasMaxLength(100);
        entity.Property(e => e.LastName).HasMaxLength(100);
        entity.Property(e => e.SendPromotions).HasColumnName("sendPromotions");
        entity.Property(e => e.State).HasMaxLength(50);
        entity.Property(e => e.Zip).HasMaxLength(10);

        entity.HasOne(d => d.Store).WithMany(p => p.SampleKitRequests)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SampleKitRequest_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SampleKitRequest> entity);
}
