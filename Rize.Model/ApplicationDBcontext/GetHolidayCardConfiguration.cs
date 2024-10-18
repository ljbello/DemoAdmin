using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class GetHolidayCardConfiguration : IEntityTypeConfiguration<GetHolidayCard>
{
    public void Configure(EntityTypeBuilder<GetHolidayCard> entity)
    {
        entity
                .HasNoKey()
                .ToView("getHolidayCards");

        entity.Property(e => e.ProductId).HasColumnName("productID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<GetHolidayCard> entity);
}
