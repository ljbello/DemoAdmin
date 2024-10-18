using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblPreviousActionConfiguration : IEntityTypeConfiguration<TblPreviousAction>
{
    public void Configure(EntityTypeBuilder<TblPreviousAction> entity)
    {
        entity
                .HasNoKey()
                .ToTable("tblPreviousActions");

        entity.HasIndex(e => e.ActionId, "ActionID");

        entity.Property(e => e.ActionId).HasColumnName("ActionID");
        entity.Property(e => e.ActionTime).HasColumnType("datetime");
        entity.Property(e => e.ActionType)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.CusCustomerGroupId).HasColumnName("Cus__CustomerGroupID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblPreviousAction> entity);
}
