using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblDepartmentProductConfiguration : IEntityTypeConfiguration<TblDepartmentProduct>
{
    public void Configure(EntityTypeBuilder<TblDepartmentProduct> entity)
    {
        entity.HasKey(e => new { e.DepDepartmentId, e.ProProductId, e.StoStoreId }).HasName("tblDepartmentProducts_PK");

        entity.ToTable("tblDepartmentProducts");

        entity.HasIndex(e => e.ProProductId, "index_7");

        entity.Property(e => e.DepDepartmentId).HasColumnName("Dep__DepartmentID");
        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductID");
        entity.Property(e => e.StoStoreId)
                .HasDefaultValue(1)
                .HasColumnName("Sto__StoreID");

        entity.HasOne(d => d.DepDepartment).WithMany(p => p.TblDepartmentProducts)
                .HasForeignKey(d => d.DepDepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDepartmentProducts_tblDepartments");

        entity.HasOne(d => d.ProProduct).WithMany(p => p.TblDepartmentProducts)
                .HasForeignKey(d => d.ProProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDepartmentProducts_tblProducts");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblDepartmentProduct> entity);
}
