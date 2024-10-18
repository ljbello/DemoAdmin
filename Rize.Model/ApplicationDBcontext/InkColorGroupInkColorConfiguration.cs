using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class InkColorGroupInkColorConfiguration : IEntityTypeConfiguration<InkColorGroupInkColor>
{
    public void Configure(EntityTypeBuilder<InkColorGroupInkColor> entity)
    {
        entity.HasKey(e => new { e.InkColorGroupId, e.InkColorId }).HasName("PK_InkColorGroupInkColors_1");

        entity.HasOne(d => d.InkColorGroup).WithMany(p => p.InkColorGroupInkColors)
                .HasForeignKey(d => d.InkColorGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InkColorGroupInkColors_InkColorGroup");

        entity.HasOne(d => d.InkColor).WithMany(p => p.InkColorGroupInkColors)
                .HasForeignKey(d => d.InkColorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InkColorGroupInkColors_tblInkColors");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<InkColorGroupInkColor> entity);
}
