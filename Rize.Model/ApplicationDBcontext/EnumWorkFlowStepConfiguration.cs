using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class EnumWorkFlowStepConfiguration : IEntityTypeConfiguration<EnumWorkFlowStep>
{
    public void Configure(EntityTypeBuilder<EnumWorkFlowStep> entity)
    {
        entity.HasKey(e => e.WorkFlowStepId).HasName("WorkFlowStep_PK");

        entity.ToTable("EnumWorkFlowStep");

        entity.HasIndex(e => e.WorkFlowStepName, "WorkFlowStep_UC1").IsUnique();

        entity.Property(e => e.WorkFlowStepId).ValueGeneratedNever();
        entity.Property(e => e.WorkFlowStepDescription)
                .HasMaxLength(250)
                .IsUnicode(false);
        entity.Property(e => e.WorkFlowStepName)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<EnumWorkFlowStep> entity);
}
