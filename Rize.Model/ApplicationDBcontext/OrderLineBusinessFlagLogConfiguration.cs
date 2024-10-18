using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderLineBusinessFlagLogConfiguration : IEntityTypeConfiguration<OrderLineBusinessFlagLog>
{
    public void Configure(EntityTypeBuilder<OrderLineBusinessFlagLog> entity)
    {
        entity.HasKey(e => e.OrderLineId).HasName("PK_OrderLineBusinessFlagLog");

        entity.ToTable("OrderLine_BusinessFlag_Log");

        entity.HasIndex(e => e.IsForBusiness, "OrderLine_BusinessFlag_Log_IX1");

        entity.Property(e => e.OrderLineId).ValueGeneratedNever();
        entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.MatchType)
                .HasMaxLength(250)
                .IsUnicode(false);
        entity.Property(e => e.ParsedText).HasColumnType("text");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderLineBusinessFlagLog> entity);
}
