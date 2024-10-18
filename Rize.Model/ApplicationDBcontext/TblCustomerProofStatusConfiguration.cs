using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCustomerProofStatusConfiguration : IEntityTypeConfiguration<TblCustomerProofStatus>
{
    public void Configure(EntityTypeBuilder<TblCustomerProofStatus> entity)
    {
        entity.HasKey(e => e.ProStaProofStatusId);

        entity.ToTable("tblCustomerProofStatus");

        entity.Property(e => e.ProStaProofStatusId).HasColumnName("ProSta__ProofStatusID");
        entity.Property(e => e.ProStaDescription)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("ProSta__Description");
        entity.Property(e => e.ProStaFriendlyName)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("ProSta__FriendlyName");
        entity.Property(e => e.ProStaProofSequence).HasColumnName("ProSta__ProofSequence");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCustomerProofStatus> entity);
}
