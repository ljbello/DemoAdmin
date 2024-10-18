using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SampleRequestHistoryConfiguration : IEntityTypeConfiguration<SampleRequestHistory>
{
    public void Configure(EntityTypeBuilder<SampleRequestHistory> entity)
    {
        entity.ToTable("SampleRequestHistory");

        entity.HasIndex(e => e.UserIp, "IX_SampleRequestHistory_UserIP").HasFillFactor(100);

        entity.HasIndex(e => new { e.StoreId, e.OrderDate }, "SampleRequestHistory_IX1");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.AddressLine1)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.City)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.OrderDate).HasColumnType("datetime");
        entity.Property(e => e.StoreId)
                .HasDefaultValue(1)
                .HasColumnName("StoreID");
        entity.Property(e => e.UserIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UserIP");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SampleRequestHistory> entity);
}
