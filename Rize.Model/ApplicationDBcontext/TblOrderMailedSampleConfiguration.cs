using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderMailedSampleConfiguration : IEntityTypeConfiguration<TblOrderMailedSample>
{
    public void Configure(EntityTypeBuilder<TblOrderMailedSample> entity)
    {
        entity.HasKey(e => e.OrdMaiSamOrderMailedSampleId);

        entity.ToTable("tblOrderMailedSamples");

        entity.HasIndex(e => e.OrdOrderId, "index_113");

        entity.Property(e => e.OrdMaiSamOrderMailedSampleId).HasColumnName("OrdMaiSam__OrderMailedSampleID");
        entity.Property(e => e.OrdMaiSamDateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("OrdMaiSam__DateCreated");
        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");

        entity.HasOne(d => d.OrdOrder).WithMany(p => p.TblOrderMailedSamples)
                .HasForeignKey(d => d.OrdOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblOrderMailedSamples_Order");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderMailedSample> entity);
}
