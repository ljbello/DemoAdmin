using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ViewDppv3orderLinesRawConfiguration : IEntityTypeConfiguration<ViewDppv3orderLinesRaw>
{
    public void Configure(EntityTypeBuilder<ViewDppv3orderLinesRaw> entity)
    {
        entity
                .HasNoKey()
                .ToView("view_DPPV3OrderLinesRaw");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ViewDppv3orderLinesRaw> entity);
}
