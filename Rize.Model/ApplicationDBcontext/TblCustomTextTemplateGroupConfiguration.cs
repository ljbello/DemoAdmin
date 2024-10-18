using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCustomTextTemplateGroupConfiguration : IEntityTypeConfiguration<TblCustomTextTemplateGroup>
{
    public void Configure(EntityTypeBuilder<TblCustomTextTemplateGroup> entity)
    {
        entity.HasKey(e => e.CusTexTemGroCustomTextTemplateGroupId).HasName("tblCustomTextTemplateGroups_PK");

        entity.ToTable("tblCustomTextTemplateGroups");

        entity.Property(e => e.CusTexTemGroCustomTextTemplateGroupId).HasColumnName("CusTexTemGro__CustomTextTemplateGroupID");
        entity.Property(e => e.CusTexTemGroCustomTextTemplateGroupYear).HasColumnName("CusTexTemGro__CustomTextTemplateGroupYear");
        entity.Property(e => e.CusTexTemGroDescription)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("CusTexTemGro__Description");

        entity.HasMany(d => d.CusTexTemCustomTextTemplates).WithMany(p => p.CusTexTemGroCustomTextTemplateGroups)
            .UsingEntity<Dictionary<string, object>>(
                "TblCustomTextTemplateGroupCustomTextTemplate",
                r => r.HasOne<TblCustomTextTemplate>().WithMany()
                        .HasForeignKey("CusTexTemCustomTextTemplateId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("tblCustomTextTemplates_tblCustomTextTemplateGroupCustomTextTemplates_FK1"),
                l => l.HasOne<TblCustomTextTemplateGroup>().WithMany()
                        .HasForeignKey("CusTexTemGroCustomTextTemplateGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("tblCustomTextTemplateGroups_tblCustomTextTemplateGroupCustomTextTemplates_FK1"),
                j =>
                {
                    j.HasKey("CusTexTemGroCustomTextTemplateGroupId", "CusTexTemCustomTextTemplateId").HasName("tblCustomTextTemplateGroupCustomTextTemplates_PK");
                    j.ToTable("tblCustomTextTemplateGroupCustomTextTemplates");
                   j.IndexerProperty<int>("CusTexTemGroCustomTextTemplateGroupId").HasColumnName("CusTexTemGro__CustomTextTemplateGroupID");
                   j.IndexerProperty<int>("CusTexTemCustomTextTemplateId").HasColumnName("CusTexTem__CustomTextTemplateID");
            });

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCustomTextTemplateGroup> entity);
}
