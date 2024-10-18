using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AdminStoreRoleTemplateConfiguration : IEntityTypeConfiguration<AdminStoreRoleTemplate>
{
    public void Configure(EntityTypeBuilder<AdminStoreRoleTemplate> entity)
    {
        entity.ToTable("AdminStoreRoleTemplate");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.RoleId).HasColumnName("RoleID");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");

        entity.HasOne(d => d.Role).WithMany(p => p.AdminStoreRoleTemplates)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_AdminStoreRoleTemplate_AdminRole");

        entity.HasOne(d => d.Store).WithMany(p => p.AdminStoreRoleTemplates)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_AdminStoreRoleTemplate_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AdminStoreRoleTemplate> entity);
}
