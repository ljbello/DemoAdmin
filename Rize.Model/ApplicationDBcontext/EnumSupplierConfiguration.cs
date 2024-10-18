using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class EnumSupplierConfiguration : IEntityTypeConfiguration<EnumSupplier>
{
    public void Configure(EntityTypeBuilder<EnumSupplier> entity)
    {
        entity.HasKey(e => e.SuppliersId).HasName("EnumSuppliers_PK");

        entity.HasIndex(e => e.SuppliersName, "EnumSuppliers_UC1").IsUnique();

        entity.Property(e => e.SuppliersId).ValueGeneratedNever();
        entity.Property(e => e.SuppliersDescription)
                .HasMaxLength(250)
                .IsUnicode(false);
        entity.Property(e => e.SuppliersName)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<EnumSupplier> entity);
}
