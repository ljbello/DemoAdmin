using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblTypestyleGroupConfiguration : IEntityTypeConfiguration<TblTypestyleGroup>
{
    public void Configure(EntityTypeBuilder<TblTypestyleGroup> entity)
    {
        entity.HasKey(e => e.TypGroTypestyleGroupId).HasName("tblTypestyleGroups_PK");

        entity.ToTable("tblTypestyleGroups");

        entity.Property(e => e.TypGroTypestyleGroupId).HasColumnName("TypGro__TypestyleGroupID");
        entity.Property(e => e.TypGroDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("TypGro__Description");
        entity.Property(e => e.TypGroTypestyleGroupYear).HasColumnName("TypGro__TypestyleGroupYear");

        entity.HasMany(d => d.TypTypestyles).WithMany(p => p.TypGroTypestyleGroups)
            .UsingEntity<Dictionary<string, object>>(
                "TblTypestyleGroupTypestyle",
                r => r.HasOne<TblTypestyle>().WithMany()
                        .HasForeignKey("TypTypestyleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("tblTypestyles_tblTypestyleGroupTypestyles_FK1"),
                l => l.HasOne<TblTypestyleGroup>().WithMany()
                        .HasForeignKey("TypGroTypestyleGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("tblTypestyleGroups_tblTypestyleGroupTypestyles_FK1"),
                j =>
                {
                    j.HasKey("TypGroTypestyleGroupId", "TypTypestyleId").HasName("tblTypestyleGroupTypestyles_PK");
                    j.ToTable("tblTypestyleGroupTypestyles");
                   j.IndexerProperty<int>("TypGroTypestyleGroupId").HasColumnName("TypGro__TypestyleGroupID");
                   j.IndexerProperty<int>("TypTypestyleId").HasColumnName("Typ__TypestyleID");
            });

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblTypestyleGroup> entity);
}
