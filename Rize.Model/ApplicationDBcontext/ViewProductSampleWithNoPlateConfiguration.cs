using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ViewProductSampleWithNoPlateConfiguration : IEntityTypeConfiguration<ViewProductSampleWithNoPlate>
{
    public void Configure(EntityTypeBuilder<ViewProductSampleWithNoPlate> entity)
    {
        entity
                .HasNoKey()
                .ToView("viewProductSampleWithNoPlates");

        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductID");
        entity.Property(e => e.ProProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Pro__ProductNumber");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ViewProductSampleWithNoPlate> entity);
}
