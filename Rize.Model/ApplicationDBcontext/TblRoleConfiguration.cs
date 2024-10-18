using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblRoleConfiguration : IEntityTypeConfiguration<TblRole>
{
    public void Configure(EntityTypeBuilder<TblRole> entity)
    {
        entity.HasKey(e => e.RoleId);

        entity.ToTable("tblRoles");

        entity.Property(e => e.RoleId)
                .ValueGeneratedNever()
                .HasColumnName("RoleID");
        entity.Property(e => e.Role)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblRole> entity);
}
