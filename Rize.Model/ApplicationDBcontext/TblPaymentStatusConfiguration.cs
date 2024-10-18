using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblPaymentStatusConfiguration : IEntityTypeConfiguration<TblPaymentStatus>
{
    public void Configure(EntityTypeBuilder<TblPaymentStatus> entity)
    {
        entity.HasKey(e => e.PayStaPaymentStatusId);

        entity.ToTable("tblPaymentStatus");

        entity.Property(e => e.PayStaPaymentStatusId)
                .ValueGeneratedNever()
                .HasColumnName("PaySta__PaymentStatusID");
        entity.Property(e => e.PayStaDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("PaySta__Description");
        entity.Property(e => e.PayStaDisplaySequence).HasColumnName("PaySta__DisplaySequence");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblPaymentStatus> entity);
}
