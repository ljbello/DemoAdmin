using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AmazonOrderConfiguration : IEntityTypeConfiguration<AmazonOrder>
{
    public void Configure(EntityTypeBuilder<AmazonOrder> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__AmazonOr__3214EC071D276B06");

        entity.ToTable("AmazonOrder");

        entity.Property(e => e.AmazonOrderId).HasMaxLength(50);
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.LastUpdatedOn).HasColumnType("datetime");
        entity.Property(e => e.OrderTotal).HasColumnType("money");
        entity.Property(e => e.PurchaseDate).HasColumnType("datetime");
        entity.Property(e => e.StoreId).HasDefaultValue(1);

        entity.HasOne(d => d.Store).WithMany(p => p.AmazonOrders)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AmazonOrder_Store");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AmazonOrder> entity);
}
