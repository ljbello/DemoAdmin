using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VOrdersWithNoProofRevisionInstructionConfiguration : IEntityTypeConfiguration<VOrdersWithNoProofRevisionInstruction>
{
    public void Configure(EntityTypeBuilder<VOrdersWithNoProofRevisionInstruction> entity)
    {
        entity
                .HasNoKey()
                .ToView("vOrdersWithNoProofRevisionInstructions");

        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderId");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VOrdersWithNoProofRevisionInstruction> entity);
}
