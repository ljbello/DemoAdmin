using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CustomerFavoriteConfiguration : IEntityTypeConfiguration<CustomerFavorite>
{
    public void Configure(EntityTypeBuilder<CustomerFavorite> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC27BFC15C35");

        entity.ToTable("CustomerFavorite");

        entity.HasIndex(e => e.CustomerLoginId, "CustomerFavorite_CustomerLoginId_IX1");

        entity.HasIndex(e => new { e.CustomerLoginId, e.CreatedOn }, "CustomerFavorite_IX2").IsDescending(false, true);

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        entity.HasOne(d => d.Product).WithMany(p => p.CustomerFavorites)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerFavorite_tblProducts");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CustomerFavorite> entity);
}
