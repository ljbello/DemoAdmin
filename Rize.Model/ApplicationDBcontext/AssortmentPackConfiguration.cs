using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AssortmentPackConfiguration : IEntityTypeConfiguration<AssortmentPack>
{
    public void Configure(EntityTypeBuilder<AssortmentPack> entity)
    {
        entity.HasKey(e => e.ProductId);

        entity.ToTable("AssortmentPack");

        entity.HasIndex(e => e.PageName, "AssortmentPack_IX1");

        entity.Property(e => e.ProductId).ValueGeneratedNever();
        entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
        entity.Property(e => e.EntityCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.EntityRank).HasDefaultValue(2147483647);
        entity.Property(e => e.MetaDescription)
                .HasMaxLength(800)
                .IsUnicode(false);
        entity.Property(e => e.MetaKeywords)
                .HasMaxLength(500)
                .IsUnicode(false);
        entity.Property(e => e.MetaTitle)
                .HasMaxLength(200)
                .IsUnicode(false);
        entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.PageName)
                .HasMaxLength(50)
                .IsUnicode(false);

        entity.HasOne(d => d.Department).WithMany(p => p.AssortmentPacks)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssortmentPack_tblDepartment");

        entity.HasOne(d => d.Product).WithOne(p => p.AssortmentPack)
                .HasForeignKey<AssortmentPack>(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssortmentPack_tblProducts");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AssortmentPack> entity);
}
