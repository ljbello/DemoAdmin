using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblAmountMisMatchConfiguration : IEntityTypeConfiguration<TblAmountMisMatch>
{
    public void Configure(EntityTypeBuilder<TblAmountMisMatch> entity)
    {
        entity
                .HasNoKey()
                .ToTable("tbl_Amount_MisMatch");

        entity.Property(e => e.AuthorizeAmount)
                .HasColumnType("money")
                .HasColumnName("Authorize Amount");
        entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .HasColumnName("Customer Name");
        entity.Property(e => e.Order).HasColumnName("Order #");
        entity.Property(e => e.SettlementAmount)
                .HasColumnType("money")
                .HasColumnName("Settlement Amount");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblAmountMisMatch> entity);
}
