using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SaleZipCodeConfiguration : IEntityTypeConfiguration<SaleZipCode>
{
    public void Configure(EntityTypeBuilder<SaleZipCode> entity)
    {
        entity
                .HasNoKey()
                .ToTable("SaleZipCode");

        entity.Property(e => e.StateId)
                .HasMaxLength(255)
                .HasColumnName("StateID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SaleZipCode> entity);
}
