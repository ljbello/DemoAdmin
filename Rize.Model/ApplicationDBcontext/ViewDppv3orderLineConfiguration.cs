using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ViewDppv3orderLineConfiguration : IEntityTypeConfiguration<ViewDppv3orderLine>
{
    public void Configure(EntityTypeBuilder<ViewDppv3orderLine> entity)
    {
        entity
                .HasNoKey()
                .ToView("view_DPPV3OrderLines");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ViewDppv3orderLine> entity);
}
