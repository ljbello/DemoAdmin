using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CustomerLoginConfiguration : IEntityTypeConfiguration<CustomerLogin>
{
    public void Configure(EntityTypeBuilder<CustomerLogin> entity)
    {
        entity.ToTable(tb => tb.HasTrigger("update_DateModified"));

        entity.HasIndex(e => e.CustomerGroupId, "CustomerGroupID");

        entity.HasIndex(e => new { e.PasswordResetToken, e.StoreId }, "CustomerLogins_IX1");

        entity.HasIndex(e => new { e.StoreId, e.Login, e.CustomerGroupId }, "CustomerLogins_IX2");

        entity.HasIndex(e => e.Id, "CustomerLogins_IX3");

        entity.HasIndex(e => new { e.Login, e.StoreId }, "CustomerLogins_Login_Unique").IsUnique();

        entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.DateModified).HasColumnType("datetime");
        entity.Property(e => e.LastLogin).HasColumnType("datetime");
        entity.Property(e => e.LockoutEndDate).HasColumnType("datetime");
        entity.Property(e => e.Login)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.StoreId)
                .HasDefaultValue(1)
                .HasColumnName("StoreID");
        entity.Property(e => e.TokenCreationDate).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CustomerLogin> entity);
}
