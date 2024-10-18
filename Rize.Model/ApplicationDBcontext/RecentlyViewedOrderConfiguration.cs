using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class RecentlyViewedOrderConfiguration : IEntityTypeConfiguration<RecentlyViewedOrder>
{
    public void Configure(EntityTypeBuilder<RecentlyViewedOrder> entity)
    {
        entity.HasKey(e => new { e.OrderId, e.UserId });

        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<RecentlyViewedOrder> entity);
}
