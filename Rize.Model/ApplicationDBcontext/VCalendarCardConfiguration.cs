using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VCalendarCardConfiguration : IEntityTypeConfiguration<VCalendarCard>
{
    public void Configure(EntityTypeBuilder<VCalendarCard> entity)
    {
        entity
                .HasNoKey()
                .ToView("vCalendarCards");

        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductId");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VCalendarCard> entity);
}
