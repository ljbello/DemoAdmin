using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AdminUserStoreConfiguration : IEntityTypeConfiguration<AdminUserStore>
{
    public void Configure(EntityTypeBuilder<AdminUserStore> entity)
    {
        entity.ToTable("AdminUserStore");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.UserId).HasColumnName("UserID");

        entity.HasOne(d => d.Store).WithMany(p => p.AdminUserStores)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdminUserStore_tblStores");

        entity.HasOne(d => d.User).WithMany(p => p.AdminUserStores)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdminUserStore_tblUsers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AdminUserStore> entity);
}
