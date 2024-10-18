using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class FacebookPromoConfiguration : IEntityTypeConfiguration<FacebookPromo>
{
    public void Configure(EntityTypeBuilder<FacebookPromo> entity)
    {
        entity.ToTable("FacebookPromo");

        entity.HasIndex(e => e.Email, "IX_FacebookPromo_Email").IsUnique();

        entity.HasIndex(e => e.Token, "IX_FacebookPromo_Token");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
        entity.Property(e => e.Address2)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Company)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false);
        entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.FulfilledDate).HasColumnType("datetime");
        entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.ModifiedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.SelectedProduct)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.State)
                .HasMaxLength(3)
                .IsUnicode(false);
        entity.Property(e => e.Token)
                .HasMaxLength(200)
                .IsUnicode(false);
        entity.Property(e => e.ZipCode)
                .HasMaxLength(15)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<FacebookPromo> entity);
}
