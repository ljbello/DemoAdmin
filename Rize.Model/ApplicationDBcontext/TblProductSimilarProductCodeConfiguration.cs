using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblProductSimilarProductCodeConfiguration : IEntityTypeConfiguration<TblProductSimilarProductCode>
{
    public void Configure(EntityTypeBuilder<TblProductSimilarProductCode> entity)
    {
        entity.HasKey(e => e.ProSimProCodProductSimilarProductCodeId);

        entity.ToTable("tblProductSimilarProductCodes");

        entity.Property(e => e.ProSimProCodProductSimilarProductCodeId).HasColumnName("ProSimProCod__ProductSimilarProductCodeID");
        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductID");
        entity.Property(e => e.SimProCodSimilarProductCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("SimProCod__SimilarProductCode");

        entity.HasOne(d => d.ProProduct).WithMany(p => p.TblProductSimilarProductCodes)
                .HasForeignKey(d => d.ProProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblProductSimilarProductCodes_tblProducts");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblProductSimilarProductCode> entity);
}
