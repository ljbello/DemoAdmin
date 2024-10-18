using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class GetCustomerGroupingContactPreferenceConfiguration : IEntityTypeConfiguration<GetCustomerGroupingContactPreference>
{
    public void Configure(EntityTypeBuilder<GetCustomerGroupingContactPreference> entity)
    {
        entity
                .HasNoKey()
                .ToView("GetCustomerGroupingContactPreferences");

        entity.Property(e => e.CusCustomerid).HasColumnName("cus__customerid");
        entity.Property(e => e.EmailOk)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("EmailOK");
        entity.Property(e => e.PhoneOk)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("PhoneOK");
        entity.Property(e => e.SnailMailOk)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("SnailMailOK");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<GetCustomerGroupingContactPreference> entity);
}
