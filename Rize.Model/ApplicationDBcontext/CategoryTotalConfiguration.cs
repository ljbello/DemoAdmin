using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CategoryTotalConfiguration : IEntityTypeConfiguration<CategoryTotal>
{
    public void Configure(EntityTypeBuilder<CategoryTotal> entity)
    {
        entity.HasKey(e => e.DepartmentId);

        entity.ToTable("CategoryTotal");

        entity.Property(e => e.DepartmentId)
                .ValueGeneratedNever()
                .HasColumnName("DepartmentID");
        entity.Property(e => e.CategoryUrl)
                .HasMaxLength(255)
                .IsUnicode(false);
        entity.Property(e => e.DateUpdated).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CategoryTotal> entity);
}
