using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCreditCardTypeConfiguration : IEntityTypeConfiguration<TblCreditCardType>
{
    public void Configure(EntityTypeBuilder<TblCreditCardType> entity)
    {
        entity.HasKey(e => e.CreCarTypCreditCardTypeId).HasName("tblCreditCardTypes_PK");

        entity.ToTable("tblCreditCardTypes");

        entity.Property(e => e.CreCarTypCreditCardTypeId).HasColumnName("CreCarTyp__CreditCardTypeID");
        entity.Property(e => e.CreCarTypDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("CreCarTyp__Description");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCreditCardType> entity);
}
