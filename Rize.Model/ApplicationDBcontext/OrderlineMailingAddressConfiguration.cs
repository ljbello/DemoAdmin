using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderlineMailingAddressConfiguration : IEntityTypeConfiguration<OrderlineMailingAddress>
{
    public void Configure(EntityTypeBuilder<OrderlineMailingAddress> entity)
    {
        entity.ToTable("OrderlineMailingAddress");

        entity.HasIndex(e => e.OrderlineId, "OrderlineMailingAddress_IX1");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ErrorCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.IsValid).HasDefaultValue(true);
        entity.Property(e => e.Line1).HasMaxLength(200);
        entity.Property(e => e.Line2).HasMaxLength(200);
        entity.Property(e => e.Line3).HasMaxLength(200);
        entity.Property(e => e.Line4).HasMaxLength(200);
        entity.Property(e => e.Line5).HasMaxLength(200);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.PrintAddressing).HasDefaultValue(true);
        entity.Property(e => e.PrintReturnAddress).HasDefaultValue(true);

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.OrderlineMailingAddresses)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_OrderlineMailingAddress_tblUsers");

        entity.HasOne(d => d.Orderline).WithMany(p => p.OrderlineMailingAddresses)
                .HasForeignKey(d => d.OrderlineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderlineMailingAddress_tblOrderLines");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderlineMailingAddress> entity);
}
