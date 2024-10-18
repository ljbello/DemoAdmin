using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ShippingGroupConfiguration : IEntityTypeConfiguration<ShippingGroup>
{
    public void Configure(EntityTypeBuilder<ShippingGroup> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__Shipping__3214EC07BABA6E1F");

        entity.ToTable("ShippingGroup");

        entity.Property(e => e.CreatedBy).HasDefaultValue(1);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.StoreId).HasDefaultValue(1);

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ShippingGroups)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShippingGroup_tblUsers");

        entity.HasOne(d => d.Store).WithMany(p => p.ShippingGroups)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShippingGroup_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ShippingGroup> entity);
}
