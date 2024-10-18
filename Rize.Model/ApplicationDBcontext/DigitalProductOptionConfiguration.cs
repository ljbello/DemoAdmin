using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DigitalProductOptionConfiguration : IEntityTypeConfiguration<DigitalProductOption>
{
    public void Configure(EntityTypeBuilder<DigitalProductOption> entity)
    {
        entity.Property(e => e.Spc)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("SPC");

        entity.HasOne(d => d.Product).WithMany(p => p.DigitalProductOptions)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DigitalProductOptions_tblProducts");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DigitalProductOption> entity);
}
