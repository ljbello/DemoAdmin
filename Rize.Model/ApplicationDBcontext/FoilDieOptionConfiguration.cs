using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class FoilDieOptionConfiguration : IEntityTypeConfiguration<FoilDieOption>
{
    public void Configure(EntityTypeBuilder<FoilDieOption> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK_FoilDieOption_1");

        entity.ToTable("FoilDieOption");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedBy).HasDefaultValue(1);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.FoilDieCode)
                .HasMaxLength(25)
                .IsUnicode(false);
        entity.Property(e => e.ImageName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.FoilDieOptionCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull);

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.FoilDieOptionModifiedByNavigations).HasForeignKey(d => d.ModifiedBy);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<FoilDieOption> entity);
}
