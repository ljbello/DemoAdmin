using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class FaqCategoryConfiguration : IEntityTypeConfiguration<FaqCategory>
{
    public void Configure(EntityTypeBuilder<FaqCategory> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__FaqCateg__3214EC0769301289");

        entity.ToTable("FaqCategory");

        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Name).HasMaxLength(100);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<FaqCategory> entity);
}
