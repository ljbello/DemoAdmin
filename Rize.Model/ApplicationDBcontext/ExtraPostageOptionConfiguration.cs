using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ExtraPostageOptionConfiguration : IEntityTypeConfiguration<ExtraPostageOption>
{
    public void Configure(EntityTypeBuilder<ExtraPostageOption> entity)
    {
        entity.ToTable("ExtraPostageOption");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ExtraPostageOption> entity);
}
