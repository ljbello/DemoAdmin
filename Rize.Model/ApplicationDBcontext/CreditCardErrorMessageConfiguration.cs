using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CreditCardErrorMessageConfiguration : IEntityTypeConfiguration<CreditCardErrorMessage>
{
    public void Configure(EntityTypeBuilder<CreditCardErrorMessage> entity)
    {
        entity.HasKey(e => e.HostResponseCode);

        entity.ToTable("CreditCardErrorMessage");

        entity.Property(e => e.HostResponseCode)
                .HasMaxLength(10)
                .IsUnicode(false);
        entity.Property(e => e.FriendlyErrorMessage)
                .HasMaxLength(255)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CreditCardErrorMessage> entity);
}
