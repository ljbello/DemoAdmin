using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class StorePaymentConfiguration : IEntityTypeConfiguration<StorePayment>
{
    public void Configure(EntityTypeBuilder<StorePayment> entity)
    {
        entity.ToTable("StorePayment");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.IsCustomer).HasDefaultValue(true);
        entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");

        entity.HasOne(d => d.PaymentType).WithMany(p => p.StorePayments)
                .HasForeignKey(d => d.PaymentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StorePayment_tblOrderPaymentMethods");

        entity.HasOne(d => d.Store).WithMany(p => p.StorePayments)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StorePayment_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<StorePayment> entity);
}
