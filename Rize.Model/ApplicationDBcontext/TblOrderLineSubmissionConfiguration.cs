using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderLineSubmissionConfiguration : IEntityTypeConfiguration<TblOrderLineSubmission>
{
    public void Configure(EntityTypeBuilder<TblOrderLineSubmission> entity)
    {
        entity.ToTable("tblOrderLineSubmission");

        entity.HasIndex(e => e.ParOrderPartId, "tblOrderLineSubmission_IX1");

        entity.HasIndex(e => e.OrdLinOrderLineId, "tblOrderLineSubmission_IX2");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.OrdLinOrderLineId).HasColumnName("OrdLin__OrderLineID");
        entity.Property(e => e.OrdLinSubDateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("OrdLinSub__DateCreated");
        entity.Property(e => e.ParOrderPartId).HasColumnName("Par__OrderPartID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderLineSubmission> entity);
}
