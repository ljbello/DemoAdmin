using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderlinePlateFileConfiguration : IEntityTypeConfiguration<OrderlinePlateFile>
{
    public void Configure(EntityTypeBuilder<OrderlinePlateFile> entity)
    {
        entity.ToTable("OrderlinePlateFile");

        entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        entity.Property(e => e.FileName)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.OrderlineId).HasColumnName("OrderlineID");
        entity.Property(e => e.SectionName)
                .HasMaxLength(100)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderlinePlateFile> entity);
}
