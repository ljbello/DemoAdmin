using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductionHolidayScheduleConfiguration : IEntityTypeConfiguration<ProductionHolidaySchedule>
{
    public void Configure(EntityTypeBuilder<ProductionHolidaySchedule> entity)
    {
        entity
                .HasNoKey()
                .ToTable("ProductionHolidaySchedule");

        entity.HasIndex(e => e.ProductionHolidayDate, "ProductionHolidayDate");

        entity.Property(e => e.ProductionHolidayDate).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductionHolidaySchedule> entity);
}
