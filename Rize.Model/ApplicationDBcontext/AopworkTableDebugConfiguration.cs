using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AopworkTableDebugConfiguration : IEntityTypeConfiguration<AopworkTableDebug>
{
    public void Configure(EntityTypeBuilder<AopworkTableDebug> entity)
    {
        entity.ToTable("AOPWorkTable_Debug");

        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderId");
        entity.Property(e => e.ReInsertReason).HasMaxLength(512);
        entity.Property(e => e.RemovalReason).HasMaxLength(512);
        entity.Property(e => e.RemovalTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AopworkTableDebug> entity);
}
