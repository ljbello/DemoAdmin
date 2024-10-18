using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ViewDiscountScheduleConfiguration : IEntityTypeConfiguration<ViewDiscountSchedule>
{
    public void Configure(EntityTypeBuilder<ViewDiscountSchedule> entity)
    {
        entity
                .HasNoKey()
                .ToView("viewDiscountSchedule");

        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.DiscountGroupId).HasColumnName("DiscountGroupID");
        entity.Property(e => e.DiscountGroupName).HasMaxLength(100);
        entity.Property(e => e.DiscountGroupScheduleId).HasColumnName("DiscountGroupScheduleID");
        entity.Property(e => e.EndDate).HasColumnType("datetime");
        entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
        entity.Property(e => e.ScheduleName).HasMaxLength(50);
        entity.Property(e => e.StartDate).HasColumnType("datetime");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ViewDiscountSchedule> entity);
}
