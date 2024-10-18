using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AopworkTableConfiguration : IEntityTypeConfiguration<AopworkTable>
{
    public void Configure(EntityTypeBuilder<AopworkTable> entity)
    {
        entity.ToTable("AOPWorkTable");

        entity.HasIndex(e => e.OrdOrderId, "AOPWorkTable_IX1");

        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderId");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AopworkTable> entity);
}
