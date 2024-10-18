using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblFrontOptionGroupConfiguration : IEntityTypeConfiguration<TblFrontOptionGroup>
{
    public void Configure(EntityTypeBuilder<TblFrontOptionGroup> entity)
    {
        entity.HasKey(e => e.FroOptGroFrontOptionGroupId).HasName("tblFrontOptionGroups_PK");

        entity.ToTable("tblFrontOptionGroups");

        entity.Property(e => e.FroOptGroFrontOptionGroupId).HasColumnName("FroOptGro__FrontOptionGroupID");
        entity.Property(e => e.FroOptGroDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("FroOptGro__Description");
        entity.Property(e => e.FroOptGroGroupYear).HasColumnName("FroOptGro__GroupYear");

        entity.HasMany(d => d.FroOptFrontOptions).WithMany(p => p.FroOptGroFrontOptionGroups)
            .UsingEntity<Dictionary<string, object>>(
                "TblFrontOptionGroupFrontOption",
                r => r.HasOne<TblFrontOption>().WithMany()
                        .HasForeignKey("FroOptFrontOptionId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("tblFrontOptions_tblFrontOptionGroupFrontOptions_FK1"),
                l => l.HasOne<TblFrontOptionGroup>().WithMany()
                        .HasForeignKey("FroOptGroFrontOptionGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("tblFrontOptionGroups_tblFrontOptionGroupFrontOptions_FK1"),
                j =>
                {
                    j.HasKey("FroOptGroFrontOptionGroupId", "FroOptFrontOptionId").HasName("tblFrontOptionGroupFrontOptions_PK");
                    j.ToTable("tblFrontOptionGroupFrontOptions");
                   j.IndexerProperty<int>("FroOptGroFrontOptionGroupId").HasColumnName("FroOptGro__FrontOptionGroupID");
                   j.IndexerProperty<int>("FroOptFrontOptionId").HasColumnName("FroOpt__FrontOptionID");
            });

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblFrontOptionGroup> entity);
}
