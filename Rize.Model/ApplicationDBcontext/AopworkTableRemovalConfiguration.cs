using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AopworkTableRemovalConfiguration : IEntityTypeConfiguration<AopworkTableRemoval>
{
    public void Configure(EntityTypeBuilder<AopworkTableRemoval> entity)
    {
        entity.ToTable("AOPWorkTable_Removals");

        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderId");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AopworkTableRemoval> entity);
}
