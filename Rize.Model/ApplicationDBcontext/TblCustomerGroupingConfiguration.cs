using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCustomerGroupingConfiguration : IEntityTypeConfiguration<TblCustomerGrouping>
{
    public void Configure(EntityTypeBuilder<TblCustomerGrouping> entity)
    {
        entity.HasKey(e => e.CusCustomerId);

        entity.ToTable("tblCustomerGrouping", tb => tb.HasTrigger("tblCustomerGrouping_UpdateDate"));

        entity.HasIndex(e => e.CusGroupId, "Cus__GroupID");

        entity.HasIndex(e => e.CusMaster, "index_66");

        entity.Property(e => e.CusCustomerId)
                .ValueGeneratedNever()
                .HasColumnName("Cus__CustomerID");
        entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.CusDateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Cus__DateCreated");
        entity.Property(e => e.CusGroupId).HasColumnName("Cus__GroupId");
        entity.Property(e => e.CusMaster).HasColumnName("Cus__Master");
        entity.Property(e => e.CusMatchType).HasColumnName("Cus__MatchType");
        entity.Property(e => e.UpdateDate).HasColumnType("datetime");

        entity.HasOne(d => d.CusCustomer).WithOne(p => p.TblCustomerGrouping)
                .HasForeignKey<TblCustomerGrouping>(d => d.CusCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCustomerGrouping_tblCustomers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCustomerGrouping> entity);
}
