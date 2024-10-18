using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CustomerHistoryPasswordConfiguration : IEntityTypeConfiguration<CustomerHistoryPassword>
{
    public void Configure(EntityTypeBuilder<CustomerHistoryPassword> entity)
    {
        entity.ToTable("CustomerHistoryPassword");

        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);

        entity.HasOne(d => d.CustomerLogin).WithMany(p => p.CustomerHistoryPasswords)
                .HasForeignKey(d => d.CustomerLoginId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerHistoryPassword_CustomerLogins");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CustomerHistoryPassword> entity);
}
