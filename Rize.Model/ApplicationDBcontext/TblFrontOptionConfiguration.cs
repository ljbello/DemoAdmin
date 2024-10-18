using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblFrontOptionConfiguration : IEntityTypeConfiguration<TblFrontOption>
{
    public void Configure(EntityTypeBuilder<TblFrontOption> entity)
    {
        entity.HasKey(e => e.FroOptFrontOptionId).HasName("tblFrontOptions_PK");

        entity.ToTable("tblFrontOptions");

        entity.Property(e => e.FroOptFrontOptionId).HasColumnName("FroOpt__FrontOptionID");
        entity.Property(e => e.FroOptFrontOptionCode)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("FroOpt__FrontOptionCode");
        entity.Property(e => e.FroOptText)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("FroOpt__Text");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblFrontOption> entity);
}
