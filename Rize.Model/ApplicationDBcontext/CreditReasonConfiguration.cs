using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CreditReasonConfiguration : IEntityTypeConfiguration<CreditReason>
{
    public void Configure(EntityTypeBuilder<CreditReason> entity)
    {
        entity.ToTable("CreditReason");

        entity.Property(e => e.Description)
                .HasMaxLength(32)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CreditReason> entity);
}
