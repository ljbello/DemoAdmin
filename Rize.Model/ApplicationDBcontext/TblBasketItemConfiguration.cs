using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblBasketItemConfiguration : IEntityTypeConfiguration<TblBasketItem>
{
    public void Configure(EntityTypeBuilder<TblBasketItem> entity)
    {
        entity.HasKey(e => e.BasIteBasketItemId).HasName("tblBasketItems_PK");

        entity.ToTable("tblBasketItems");

        entity.Property(e => e.BasIteBasketItemId)
                .ValueGeneratedNever()
                .HasColumnName("BasIte__BasketItemID");
        entity.Property(e => e.BasBasketId).HasColumnName("Bas__BasketID");

        entity.HasOne(d => d.BasBasket).WithMany(p => p.TblBasketItems)
                .HasForeignKey(d => d.BasBasketId)
                .HasConstraintName("tblBasket_tblBasketItems_FK1");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblBasketItem> entity);
}
