﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VOrdersWithAllOrderLinesAssortmentPackConfiguration : IEntityTypeConfiguration<VOrdersWithAllOrderLinesAssortmentPack>
{
    public void Configure(EntityTypeBuilder<VOrdersWithAllOrderLinesAssortmentPack> entity)
    {
        entity
                .HasNoKey()
                .ToView("vOrdersWithAllOrderLinesAssortmentPacks");

        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderId");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VOrdersWithAllOrderLinesAssortmentPack> entity);
}
