using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblSupplierStateConfiguration : IEntityTypeConfiguration<TblSupplierState>
{
    public void Configure(EntityTypeBuilder<TblSupplierState> entity)
    {
        entity.HasKey(e => new { e.SupSupplierId, e.StaStateId }).HasName("tblSupplierStates_PK");

        entity.ToTable("tblSupplierStates");

        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");
        entity.Property(e => e.StaStateId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Sta__StateID");
        entity.Property(e => e.ShiMetShippingMethodId).HasColumnName("ShiMet__ShippingMethodID");

        entity.HasOne(d => d.StaState).WithMany(p => p.TblSupplierStates)
                .HasForeignKey(d => d.StaStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSupplierStates_tblStates");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblSupplierState> entity);
}
