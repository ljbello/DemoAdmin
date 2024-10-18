using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblAuthorizationBankAccountTypeConfiguration : IEntityTypeConfiguration<TblAuthorizationBankAccountType>
{
    public void Configure(EntityTypeBuilder<TblAuthorizationBankAccountType> entity)
    {
        entity.HasKey(e => e.AutBanAccTypBankAccountTypeId);

        entity.ToTable("tblAuthorizationBankAccountTypes");

        entity.Property(e => e.AutBanAccTypBankAccountTypeId)
                .ValueGeneratedNever()
                .HasColumnName("AutBanAccTyp__Bank_Account_TypeID");
        entity.Property(e => e.AutBanAccTypDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("AutBanAccTyp__Description");
        entity.Property(e => e.AutBanAccTypSequence).HasColumnName("AutBanAccTyp__Sequence");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblAuthorizationBankAccountType> entity);
}
