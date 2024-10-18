using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderStatusConfiguration : IEntityTypeConfiguration<TblOrderStatus>
{
    public void Configure(EntityTypeBuilder<TblOrderStatus> entity)
    {
        entity.HasKey(e => e.OrdStaOrderStatusId).HasName("tblOrderStatuses_PK");

        entity.ToTable("tblOrderStatuses");

        entity.Property(e => e.OrdStaOrderStatusId).HasColumnName("OrdSta__OrderStatusID");
        entity.Property(e => e.ColorCode)
                .HasMaxLength(15)
                .IsUnicode(false);
        entity.Property(e => e.Display).HasDefaultValue(true);
        entity.Property(e => e.OrdStaDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("OrdSta__Description");
        entity.Property(e => e.OrdStaDisplaySequence).HasColumnName("OrdSta__DisplaySequence");
        entity.Property(e => e.OrdStaFriendlyDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("OrdSta__FriendlyDescription");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderStatus> entity);
}
