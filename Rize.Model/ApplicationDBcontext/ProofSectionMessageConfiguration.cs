using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProofSectionMessageConfiguration : IEntityTypeConfiguration<ProofSectionMessage>
{
    public void Configure(EntityTypeBuilder<ProofSectionMessage> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__ProofSec__3214EC07F07AFEF5");

        entity.ToTable("ProofSectionMessage");

        entity.HasIndex(e => new { e.OrderLineId, e.CreatedBy }, "ProofSectionMessage_IX1");

        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.Message).HasMaxLength(800);
        entity.Property(e => e.SectionName).HasMaxLength(50);

        entity.HasOne(d => d.OrderLine).WithMany(p => p.ProofSectionMessages)
                .HasForeignKey(d => d.OrderLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProofSectionMessage_tblOrderLines");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProofSectionMessage> entity);
}
