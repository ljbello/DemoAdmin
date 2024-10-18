using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CreditReasonDetailConfiguration : IEntityTypeConfiguration<CreditReasonDetail>
{
    public void Configure(EntityTypeBuilder<CreditReasonDetail> entity)
    {
        entity.ToTable("CreditReasonDetail");

        entity.Property(e => e.Description)
                .HasMaxLength(128)
                .IsUnicode(false);
        entity.Property(e => e.Group)
                .HasMaxLength(20)
                .IsUnicode(false);

        entity.HasOne(d => d.CreditReason).WithMany(p => p.CreditReasonDetails)
                .HasForeignKey(d => d.CreditReasonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditReason_CreditReasonDetail");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CreditReasonDetail> entity);
}
