using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCustomTextTemplateLineConfiguration : IEntityTypeConfiguration<TblCustomTextTemplateLine>
{
    public void Configure(EntityTypeBuilder<TblCustomTextTemplateLine> entity)
    {
        entity.HasKey(e => e.CusTexTemLinCustomTextTemplateLineId).HasName("tblCustomTextTemplateLines_PK");

        entity.ToTable("tblCustomTextTemplateLines");

        entity.Property(e => e.CusTexTemLinCustomTextTemplateLineId).HasColumnName("CusTexTemLin__CustomTextTemplateLineID");
        entity.Property(e => e.CusTexTemCustomTextTemplateId).HasColumnName("CusTexTem__CustomTextTemplateID");
        entity.Property(e => e.CusTexTemLinLineNumber).HasColumnName("CusTexTemLin__LineNumber");
        entity.Property(e => e.CusTexTemLinText)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("CusTexTemLin__Text");

        entity.HasOne(d => d.CusTexTemCustomTextTemplate).WithMany(p => p.TblCustomTextTemplateLines)
                .HasForeignKey(d => d.CusTexTemCustomTextTemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblCustomTextTemplates_tblCustomTextTemplateLines_FK1");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCustomTextTemplateLine> entity);
}
