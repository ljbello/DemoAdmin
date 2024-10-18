using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AnnualBudgetConfiguration : IEntityTypeConfiguration<AnnualBudget>
{
    public void Configure(EntityTypeBuilder<AnnualBudget> entity)
    {
        entity
                .HasNoKey()
                .ToTable("AnnualBudget");

        entity.Property(e => e.SalesPreTax).HasColumnType("money");
        entity.Property(e => e.Settlement).HasColumnType("money");
        entity.Property(e => e.Shipping).HasColumnType("money");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.SubTotal).HasColumnType("money");
        entity.Property(e => e.Tax).HasColumnType("money");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AnnualBudget> entity);
}
