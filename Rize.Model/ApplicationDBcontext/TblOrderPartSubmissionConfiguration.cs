using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderPartSubmissionConfiguration : IEntityTypeConfiguration<TblOrderPartSubmission>
{
    public void Configure(EntityTypeBuilder<TblOrderPartSubmission> entity)
    {
        entity
                .HasNoKey()
                .ToTable("tblOrderPartSubmission");

        entity.HasIndex(e => e.ParOrderPartId, "tblOrderPartSubmission_IX1");

        entity.Property(e => e.OrdParSubDateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("OrdParSub__DateCreated");
        entity.Property(e => e.OrdParSubDateLastRequest)
                .HasColumnType("datetime")
                .HasColumnName("OrdParSub__DateLastRequest");
        entity.Property(e => e.OrdParSubDateSubmitted)
                .HasColumnType("datetime")
                .HasColumnName("OrdParSub__DateSubmitted");
        entity.Property(e => e.OrdParSubDateVerified)
                .HasColumnType("datetime")
                .HasColumnName("OrdParSub__DateVerified");
        entity.Property(e => e.OrdParSubSubmissionType)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("OrdParSub__SubmissionType");
        entity.Property(e => e.OrdParSubTotalRequests).HasColumnName("OrdParSub__TotalRequests");
        entity.Property(e => e.OrdParSubXmlfileNameRequest)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("OrdParSub__XMLFileNameRequest");
        entity.Property(e => e.OrdParSubXmlfileNameResponse)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("OrdParSub__XMLFileNameResponse");
        entity.Property(e => e.OrdSubStaOrderSubmissionStatusId).HasColumnName("OrdSubSta__OrderSubmissionStatusID");
        entity.Property(e => e.ParOrderPartId).HasColumnName("Par__OrderPartID");


        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderPartSubmission> entity);
}
