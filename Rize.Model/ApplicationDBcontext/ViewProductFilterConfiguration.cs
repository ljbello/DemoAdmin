using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ViewProductFilterConfiguration : IEntityTypeConfiguration<ViewProductFilter>
{
    public void Configure(EntityTypeBuilder<ViewProductFilter> entity)
    {
        entity
                .HasNoKey()
                .ToView("viewProductFilters");

        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ViewProductFilter> entity);
}
