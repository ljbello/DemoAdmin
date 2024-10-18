using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DeliveryEstimationCategoryElementConfiguration : IEntityTypeConfiguration<DeliveryEstimationCategoryElement>
{
    public void Configure(EntityTypeBuilder<DeliveryEstimationCategoryElement> entity)
    {
        entity.ToTable("DeliveryEstimationCategoryElement");

        entity.HasIndex(e => new { e.Status, e.DeliveryEstimationCategoryId, e.DeliveryEstimationCategoryElement1 }, "DeliveryEstimationCategoryElement_IX1");

        entity.Property(e => e.DeliveryEstimationCategoryElementId).HasColumnName("DeliveryEstimationCategoryElementID");
        entity.Property(e => e.DeliveryEstimationCategoryElement1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DeliveryEstimationCategoryElement");
        entity.Property(e => e.DeliveryEstimationCategoryId).HasColumnName("DeliveryEstimationCategoryID");
        entity.Property(e => e.DisplayName)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Status).HasDefaultValue(true);

        entity.HasOne(d => d.DeliveryEstimationCategory).WithMany(p => p.DeliveryEstimationCategoryElements)
                .HasForeignKey(d => d.DeliveryEstimationCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeliveryEstimationCategoryElement_DeliveryEstimationCategory");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DeliveryEstimationCategoryElement> entity);
}
