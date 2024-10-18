using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderLineBusinessFlagKeywordConfiguration : IEntityTypeConfiguration<OrderLineBusinessFlagKeyword>
{
    public void Configure(EntityTypeBuilder<OrderLineBusinessFlagKeyword> entity)
    {
        entity.ToTable("OrderLine_BusinessFlag_Keywords");

        entity.Property(e => e.ExclusionKeyword)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Keyword)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderLineBusinessFlagKeyword> entity);
}
