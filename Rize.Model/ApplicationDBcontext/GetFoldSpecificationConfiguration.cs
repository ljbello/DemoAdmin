using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class GetFoldSpecificationConfiguration : IEntityTypeConfiguration<GetFoldSpecification>
{
    public void Configure(EntityTypeBuilder<GetFoldSpecification> entity)
    {
        entity
                .HasNoKey()
                .ToView("GetFoldSpecification");

        entity.Property(e => e.FoldSpecifier)
                .HasMaxLength(33)
                .IsUnicode(false);
        entity.Property(e => e.Productid).HasColumnName("productid");
        entity.Property(e => e.Storeid).HasColumnName("storeid");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<GetFoldSpecification> entity);
}
