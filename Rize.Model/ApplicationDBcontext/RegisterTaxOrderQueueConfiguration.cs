using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class RegisterTaxOrderQueueConfiguration : IEntityTypeConfiguration<RegisterTaxOrderQueue>
{
    public void Configure(EntityTypeBuilder<RegisterTaxOrderQueue> entity)
    {
        entity.HasKey(e => e.OrderId);

        entity.ToTable("RegisterTaxOrderQueue");

        entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("OrderID");
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<RegisterTaxOrderQueue> entity);
}
