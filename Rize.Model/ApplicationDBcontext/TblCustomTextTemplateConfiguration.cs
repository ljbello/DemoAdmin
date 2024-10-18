using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCustomTextTemplateConfiguration : IEntityTypeConfiguration<TblCustomTextTemplate>
{
    public void Configure(EntityTypeBuilder<TblCustomTextTemplate> entity)
    {
        entity.HasKey(e => e.CusTexTemCustomTextTemplateId).HasName("tblCustomTextTemplates_PK");

        entity.ToTable("tblCustomTextTemplates");

        entity.Property(e => e.CusTexTemCustomTextTemplateId).HasColumnName("CusTexTem__CustomTextTemplateID");
        entity.Property(e => e.AreAreaId).HasColumnName("Are__AreaID");
        entity.Property(e => e.CusTexTemDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("CusTexTem__Description");

        entity.HasOne(d => d.AreArea).WithMany(p => p.TblCustomTextTemplates)
                .HasForeignKey(d => d.AreAreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblAreas_tblCustomTextTemplates_FK1");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCustomTextTemplate> entity);
}
