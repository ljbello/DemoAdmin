using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class RptOrderPaymentIssueConfiguration : IEntityTypeConfiguration<RptOrderPaymentIssue>
{
    public void Configure(EntityTypeBuilder<RptOrderPaymentIssue> entity)
    {
        entity.HasKey(e => e.IssueId);

        entity.ToTable("rptOrderPaymentIssue");

        entity.Property(e => e.IssueId).HasColumnName("IssueID");
        entity.Property(e => e.Createdate).HasDefaultValueSql("(getdate())");
        entity.Property(e => e.OrderId).HasColumnName("OrderID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<RptOrderPaymentIssue> entity);
}
