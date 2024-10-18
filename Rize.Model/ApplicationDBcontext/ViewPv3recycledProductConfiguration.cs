using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ViewPv3recycledProductConfiguration : IEntityTypeConfiguration<ViewPv3recycledProduct>
{
    public void Configure(EntityTypeBuilder<ViewPv3recycledProduct> entity)
    {
        entity
                .HasNoKey()
                .ToView("viewPV3RecycledProducts");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ViewPv3recycledProduct> entity);
}
