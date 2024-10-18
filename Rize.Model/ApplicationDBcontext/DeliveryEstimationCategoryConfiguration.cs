using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DeliveryEstimationCategoryConfiguration : IEntityTypeConfiguration<DeliveryEstimationCategory>
{
    public void Configure(EntityTypeBuilder<DeliveryEstimationCategory> entity)
    {
        entity.ToTable("DeliveryEstimationCategory");

        entity.HasIndex(e => e.Status, "DeliveryEstimationCategory_IX1");

        entity.Property(e => e.DeliveryEstimationCategoryId).HasColumnName("DeliveryEstimationCategoryID");
        entity.Property(e => e.DeliveryEstimationCategory1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DeliveryEstimationCategory");
        entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Status).HasDefaultValue(true);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DeliveryEstimationCategory> entity);
}
