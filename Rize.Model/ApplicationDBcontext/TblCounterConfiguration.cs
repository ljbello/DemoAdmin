using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCounterConfiguration : IEntityTypeConfiguration<TblCounter>
{
    public void Configure(EntityTypeBuilder<TblCounter> entity)
    {
        entity.HasKey(e => e.CouCounterId);

        entity.ToTable("tblCounters");

        entity.Property(e => e.CouCounterId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Cou__CounterID");
        entity.Property(e => e.CouCounterValue).HasColumnName("Cou__CounterValue");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCounter> entity);
}
