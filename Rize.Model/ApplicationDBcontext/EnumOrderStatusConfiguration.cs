using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class EnumOrderStatusConfiguration : IEntityTypeConfiguration<EnumOrderStatus>
{
    public void Configure(EntityTypeBuilder<EnumOrderStatus> entity)
    {
        entity.HasKey(e => e.OrderStatusesId).HasName("EnumOrderStatuses_PK");

        entity.HasIndex(e => e.OrderStatusesName, "EnumOrderStatuses_UC1").IsUnique();

        entity.Property(e => e.OrderStatusesId).ValueGeneratedNever();
        entity.Property(e => e.OrderStatusesDescription)
                .HasMaxLength(250)
                .IsUnicode(false);
        entity.Property(e => e.OrderStatusesName)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<EnumOrderStatus> entity);
}
