using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ExactTargetEmailRetryIntervalConfiguration : IEntityTypeConfiguration<ExactTargetEmailRetryInterval>
{
    public void Configure(EntityTypeBuilder<ExactTargetEmailRetryInterval> entity)
    {
        entity.HasKey(e => e.EmailRetryId);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ExactTargetEmailRetryInterval> entity);
}
