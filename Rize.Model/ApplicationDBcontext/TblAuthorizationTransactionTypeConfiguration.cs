using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblAuthorizationTransactionTypeConfiguration : IEntityTypeConfiguration<TblAuthorizationTransactionType>
{
    public void Configure(EntityTypeBuilder<TblAuthorizationTransactionType> entity)
    {
        entity.HasKey(e => e.AutTraTypAuthorizationTransactionTypeId);

        entity.ToTable("tblAuthorizationTransactionTypes");

        entity.Property(e => e.AutTraTypAuthorizationTransactionTypeId)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("AutTraTyp__AuthorizationTransactionTypeID");
        entity.Property(e => e.AutTraTypDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("AutTraTyp__Description");
        entity.Property(e => e.AutTraTypSequence).HasColumnName("AutTraTyp__Sequence");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblAuthorizationTransactionType> entity);
}
