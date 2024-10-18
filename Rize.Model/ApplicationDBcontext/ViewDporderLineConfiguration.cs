using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ViewDporderLineConfiguration : IEntityTypeConfiguration<ViewDporderLine>
{
    public void Configure(EntityTypeBuilder<ViewDporderLine> entity)
    {
        entity
                .HasNoKey()
                .ToView("view_DPOrderLines");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ViewDporderLine> entity);
}
