using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AutoTriggerActionLookUpConfiguration : IEntityTypeConfiguration<AutoTriggerActionLookUp>
{
    public void Configure(EntityTypeBuilder<AutoTriggerActionLookUp> entity)
    {
        entity.ToTable("AutoTriggerActionLookUp");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.ActionName)
                .HasMaxLength(200)
                .IsUnicode(false);
        entity.Property(e => e.ProcessProcedure)
                .HasMaxLength(200)
                .IsUnicode(false);
        entity.Property(e => e.SubActionName)
                .HasMaxLength(200)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AutoTriggerActionLookUp> entity);
}
