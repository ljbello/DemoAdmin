using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderPaymentMethodConfiguration : IEntityTypeConfiguration<TblOrderPaymentMethod>
{
    public void Configure(EntityTypeBuilder<TblOrderPaymentMethod> entity)
    {
        entity.HasKey(e => e.OrdPayMetOrderPaymentMethodId);

        entity.ToTable("tblOrderPaymentMethods");

        entity.Property(e => e.OrdPayMetOrderPaymentMethodId)
                .ValueGeneratedNever()
                .HasColumnName("OrdPayMet__OrderPaymentMethodID");
        entity.Property(e => e.OrdPayMetDescription)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OrdPayMet__Description");
        entity.Property(e => e.OrdPayMetSequence).HasColumnName("OrdPayMet__Sequence");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderPaymentMethod> entity);
}
