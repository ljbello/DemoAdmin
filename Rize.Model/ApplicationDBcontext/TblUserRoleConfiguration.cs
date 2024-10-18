using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblUserRoleConfiguration : IEntityTypeConfiguration<TblUserRole>
{
    public void Configure(EntityTypeBuilder<TblUserRole> entity)
    {
        entity.HasKey(e => new { e.UserId, e.RoleId });

        entity.ToTable("tblUserRoles");

        entity.Property(e => e.UserId).HasColumnName("UserID");
        entity.Property(e => e.RoleId).HasColumnName("RoleID");

        entity.HasOne(d => d.Role).WithMany(p => p.TblUserRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblUserRoles_tblRoles");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblUserRole> entity);
}
