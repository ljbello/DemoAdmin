using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderlineSectionProofConfiguration : IEntityTypeConfiguration<OrderlineSectionProof>
{
    public void Configure(EntityTypeBuilder<OrderlineSectionProof> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK_SectionProof");

        entity.ToTable("OrderlineSectionProof");

        entity.HasIndex(e => new { e.OrderlineId, e.SectionName }, "OrderlineSectionProof_IX1");

        entity.HasIndex(e => new { e.StatusId, e.ProofRequestId }, "OrderlineSectionProof_IX2");

        entity.HasIndex(e => e.ProofRequestId, "OrderlineSectionProof_IX3");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.RevisionNotes)
                .HasMaxLength(800)
                .IsUnicode(false);
        entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

        entity.HasOne(d => d.Orderline).WithMany(p => p.OrderlineSectionProofs)
                .HasForeignKey(d => d.OrderlineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderlineSectionProof_tblOrderLines");

        entity.HasOne(d => d.ProofRequest).WithMany(p => p.OrderlineSectionProofs)
                .HasForeignKey(d => d.ProofRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderlineSectionProof_CustomerProofRequest");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderlineSectionProof> entity);
}
