using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VwSalesByDateConfiguration : IEntityTypeConfiguration<VwSalesByDate>
{
    public void Configure(EntityTypeBuilder<VwSalesByDate> entity)
    {
        entity
                .HasNoKey()
                .ToView("vw_sales_by_date");

        entity.Property(e => e.OrderDate).HasColumnType("datetime");
        entity.Property(e => e.SettlementDollarAmount).HasColumnType("money");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VwSalesByDate> entity);
}
