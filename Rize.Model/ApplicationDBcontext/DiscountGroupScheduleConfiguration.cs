using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DiscountGroupScheduleConfiguration : IEntityTypeConfiguration<DiscountGroupSchedule>
{
    public void Configure(EntityTypeBuilder<DiscountGroupSchedule> entity)
    {
        entity.ToTable("DiscountGroupSchedule");

        entity.Property(e => e.DiscountGroupScheduleId).HasColumnName("DiscountGroupScheduleID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.DiscountGroupId).HasColumnName("DiscountGroupID");
        entity.Property(e => e.EndDate).HasColumnType("datetime");
        entity.Property(e => e.Name).HasMaxLength(50);
        entity.Property(e => e.StartDate).HasColumnType("datetime");

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.DiscountGroupSchedules)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountGroupSchedule_tblUsers");

        entity.HasOne(d => d.DiscountGroup).WithMany(p => p.DiscountGroupSchedules)
                .HasForeignKey(d => d.DiscountGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountGroupSchedule_DiscountGroup");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DiscountGroupSchedule> entity);
}
