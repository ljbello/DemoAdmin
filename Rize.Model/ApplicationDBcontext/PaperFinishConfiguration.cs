using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PaperFinishConfiguration : IEntityTypeConfiguration<PaperFinish>
{
    public void Configure(EntityTypeBuilder<PaperFinish> entity)
    {
        entity.ToTable("PaperFinish");

        entity.Property(e => e.PaperFinishId).ValueGeneratedNever();
        entity.Property(e => e.DisplayName).HasMaxLength(50);
        entity.Property(e => e.Name).HasMaxLength(50);
        entity.Property(e => e.SupplierCardFrontFinish).HasMaxLength(50);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PaperFinish> entity);
}
