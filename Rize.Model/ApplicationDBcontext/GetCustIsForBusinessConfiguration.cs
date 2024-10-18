using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class GetCustIsForBusinessConfiguration : IEntityTypeConfiguration<GetCustIsForBusiness>
{
    public void Configure(EntityTypeBuilder<GetCustIsForBusiness> entity)
    {
        entity
                .HasNoKey()
                .ToView("GetCustIsForBusiness");

        entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<GetCustIsForBusiness> entity);
}
