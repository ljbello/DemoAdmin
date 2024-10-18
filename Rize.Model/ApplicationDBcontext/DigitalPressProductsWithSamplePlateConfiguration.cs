using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DigitalPressProductsWithSamplePlateConfiguration : IEntityTypeConfiguration<DigitalPressProductsWithSamplePlate>
{
    public void Configure(EntityTypeBuilder<DigitalPressProductsWithSamplePlate> entity)
    {
        entity.HasKey(e => e.ProProductId);

        entity.Property(e => e.ProProductId)
                .ValueGeneratedNever()
                .HasColumnName("Pro__ProductID");
        entity.Property(e => e.ExistingPlates)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DigitalPressProductsWithSamplePlate> entity);
}
