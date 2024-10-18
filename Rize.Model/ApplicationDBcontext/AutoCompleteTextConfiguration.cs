using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AutoCompleteTextConfiguration : IEntityTypeConfiguration<AutoCompleteText>
{
    public void Configure(EntityTypeBuilder<AutoCompleteText> entity)
    {
        entity.ToTable("AutoCompleteText");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Description).IsUnicode(false);
        entity.Property(e => e.SearchType)
                .HasMaxLength(2)
                .IsUnicode(false);
        entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AutoCompleteText> entity);
}
