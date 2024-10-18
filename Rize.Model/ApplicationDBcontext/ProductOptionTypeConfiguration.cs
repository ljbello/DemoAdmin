using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductOptionTypeConfiguration : IEntityTypeConfiguration<ProductOptionType>
{
    public void Configure(EntityTypeBuilder<ProductOptionType> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__ProductO__3214EC079E602B32");

        entity.ToTable("ProductOptionType");

        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.FriendlyName)
                .HasMaxLength(200)
                .IsUnicode(false);
        entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ProductOptionTypes)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductOptionType_tblUsers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductOptionType> entity);
}
