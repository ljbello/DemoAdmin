using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblShippingMethodConfiguration : IEntityTypeConfiguration<TblShippingMethod>
{
    public void Configure(EntityTypeBuilder<TblShippingMethod> entity)
    {
        entity.HasKey(e => e.ShiMetShippingMethodId).HasName("tblShippingMethods_PK");

        entity.ToTable("tblShippingMethods");

        entity.Property(e => e.ShiMetShippingMethodId).HasColumnName("ShiMet__ShippingMethodID");
        entity.Property(e => e.Abb)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
        entity.Property(e => e.ShiMetDisplaySequence).HasColumnName("ShiMet__DisplaySequence");
        entity.Property(e => e.ShiMetStrDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("ShiMet__strDescription");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblShippingMethod> entity);
}
