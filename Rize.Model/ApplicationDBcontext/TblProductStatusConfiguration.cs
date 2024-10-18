using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblProductStatusConfiguration : IEntityTypeConfiguration<TblProductStatus>
{
    public void Configure(EntityTypeBuilder<TblProductStatus> entity)
    {
        entity.HasKey(e => e.ProStaProductStatusId).HasName("tblProductStatuses_PK");

        entity.ToTable("tblProductStatuses");

        entity.Property(e => e.ProStaProductStatusId).HasColumnName("ProSta__ProductStatusID");
        entity.Property(e => e.ProStaDescription)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("ProSta__Description");
        entity.Property(e => e.ProStaDisplay).HasColumnName("ProSta__Display");
        entity.Property(e => e.ProStaFriendlyDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ProSta__FriendlyDescription");
        entity.Property(e => e.ProStaFriendlyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProSta__FriendlyName");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblProductStatus> entity);
}
