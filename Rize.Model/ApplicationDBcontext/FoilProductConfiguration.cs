using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class FoilProductConfiguration : IEntityTypeConfiguration<FoilProduct>
{
    public void Configure(EntityTypeBuilder<FoilProduct> entity)
    {
        entity.HasKey(e => e.ProductId);

        entity.ToTable("FoilProduct");

        entity.Property(e => e.ProductId).ValueGeneratedNever();
        entity.Property(e => e.Spc)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("SPC");

        entity.HasOne(d => d.Product).WithOne(p => p.FoilProduct)
                .HasForeignKey<FoilProduct>(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FoilProduct_tblProducts");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<FoilProduct> entity);
}
