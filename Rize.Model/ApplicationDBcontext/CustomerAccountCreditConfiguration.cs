using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CustomerAccountCreditConfiguration : IEntityTypeConfiguration<CustomerAccountCredit>
{
    public void Configure(EntityTypeBuilder<CustomerAccountCredit> entity)
    {
        entity.HasKey(e => e.CustomerAccountCreditId).HasName("PK_CustomerAccountCreditID");

        entity.ToTable("CustomerAccountCredit");

        entity.HasIndex(e => new { e.CustomerAccountId, e.CurrentAmount }, "CustomerAccountCredit_IX1");

        entity.HasIndex(e => e.CurrentAmount, "CustomerAccountCredit_IX2");

        entity.Property(e => e.CustomerAccountCreditId).HasColumnName("CustomerAccountCreditID");
        entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.CurrentAmount).HasColumnType("money");
        entity.Property(e => e.CustomerAccountId).HasColumnName("CustomerAccountID");
        entity.Property(e => e.IsAllowOffsetShipping).HasDefaultValue(false);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.Name)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.OrderId).HasColumnName("OrderID");
        entity.Property(e => e.OriginalAmount).HasColumnType("money");
        entity.Property(e => e.Reason)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.ReasonDetail)
                .HasMaxLength(128)
                .IsUnicode(false);

        entity.HasOne(d => d.CustomerAccount).WithMany(p => p.CustomerAccountCredits)
                .HasForeignKey(d => d.CustomerAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerAccountCredit_CustomerAccount");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CustomerAccountCredit> entity);
}
