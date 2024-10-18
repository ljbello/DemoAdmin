using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CustomerProofRequestConfiguration : IEntityTypeConfiguration<CustomerProofRequest>
{
    public void Configure(EntityTypeBuilder<CustomerProofRequest> entity)
    {
        entity.ToTable("CustomerProofRequest");

        entity.HasIndex(e => e.OrderGuid, "CustomerProofRequest_IX1");

        entity.HasIndex(e => e.ProofRequestId, "CustomerProofRequest_IX2");

        entity.HasIndex(e => e.ProofRequestId, "CustomerProofRequest_IX3").IsUnique();

        entity.Property(e => e.CustomerProofRequestId).HasColumnName("CustomerProofRequestID");
        entity.Property(e => e.CreatedBy).HasDefaultValue(1);
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.SubmittedOn).HasColumnType("datetime");

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CustomerProofRequestCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull);

        entity.HasOne(d => d.SubmittedByNavigation).WithMany(p => p.CustomerProofRequestSubmittedByNavigations).HasForeignKey(d => d.SubmittedBy);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CustomerProofRequest> entity);
}
