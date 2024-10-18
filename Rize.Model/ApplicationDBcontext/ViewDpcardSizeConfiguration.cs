using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ViewDpcardSizeConfiguration : IEntityTypeConfiguration<ViewDpcardSize>
{
    public void Configure(EntityTypeBuilder<ViewDpcardSize> entity)
    {
        entity
                .HasNoKey()
                .ToView("view_DPCardSize");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ViewDpcardSize> entity);
}
