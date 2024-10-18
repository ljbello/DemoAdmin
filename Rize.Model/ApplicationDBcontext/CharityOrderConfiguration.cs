using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CharityOrderConfiguration : IEntityTypeConfiguration<CharityOrder>
{
    public void Configure(EntityTypeBuilder<CharityOrder> entity)
    {
        entity.ToTable("CharityOrder");

        entity.Property(e => e.AssociatedCharity).HasMaxLength(100);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CharityOrder> entity);
}
