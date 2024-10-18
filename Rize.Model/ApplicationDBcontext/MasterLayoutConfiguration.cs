using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class MasterLayoutConfiguration : IEntityTypeConfiguration<MasterLayout>
{
    public void Configure(EntityTypeBuilder<MasterLayout> entity)
    {
        entity.ToTable("MasterLayout");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        entity.HasOne(d => d.Layout).WithMany(p => p.MasterLayouts)
                .HasForeignKey(d => d.LayoutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MasterLayout_Layout");

        entity.HasOne(d => d.Variation).WithMany(p => p.MasterLayouts)
                .HasForeignKey(d => d.VariationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MasterLayout_ProductVariation");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<MasterLayout> entity);
}
