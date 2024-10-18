using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ExactTargetEmailApiObjectConfiguration : IEntityTypeConfiguration<ExactTargetEmailApiObject>
{
    public void Configure(EntityTypeBuilder<ExactTargetEmailApiObject> entity)
    {
        entity.HasKey(e => new { e.ExactTargetEmailId, e.Sequence });

        entity.Property(e => e.ApiObjectXml)
                .HasColumnType("xml")
                .HasColumnName("apiObjectXml");
        entity.Property(e => e.RequestId)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ReturnXml)
                .HasColumnType("xml")
                .HasColumnName("returnXml");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ExactTargetEmailApiObject> entity);
}
