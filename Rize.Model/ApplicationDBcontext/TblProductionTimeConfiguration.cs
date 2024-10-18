using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblProductionTimeConfiguration : IEntityTypeConfiguration<TblProductionTime>
{
    public void Configure(EntityTypeBuilder<TblProductionTime> entity)
    {
        entity.HasKey(e => e.ProTimProductionTimeId).HasName("tblProductionTimes_PK");

        entity.ToTable("tblProductionTimes");

        entity.Property(e => e.ProTimProductionTimeId)
                .ValueGeneratedNever()
                .HasColumnName("ProTim__ProductionTimeID");
        entity.Property(e => e.ProTimDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("ProTim__Description");
        entity.Property(e => e.ProTimDisplayOrder).HasColumnName("ProTim__DisplayOrder");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblProductionTime> entity);
}
