using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class UspsorderLineConfiguration : IEntityTypeConfiguration<UspsorderLine>
{
    public void Configure(EntityTypeBuilder<UspsorderLine> entity)
    {
        entity.HasKey(e => e.OrderLineId);

        entity.ToTable("USPSOrderLine");

        entity.Property(e => e.OrderLineId).ValueGeneratedNever();
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Status).HasMaxLength(800);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<UspsorderLine> entity);
}
