using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ViewDppv2orderLineConfiguration : IEntityTypeConfiguration<ViewDppv2orderLine>
{
    public void Configure(EntityTypeBuilder<ViewDppv2orderLine> entity)
    {
        entity
                .HasNoKey()
                .ToView("view_DPPV2OrderLines");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ViewDppv2orderLine> entity);
}
