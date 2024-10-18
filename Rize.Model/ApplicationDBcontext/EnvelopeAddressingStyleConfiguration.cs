using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class EnvelopeAddressingStyleConfiguration : IEntityTypeConfiguration<EnvelopeAddressingStyle>
{
    public void Configure(EntityTypeBuilder<EnvelopeAddressingStyle> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__Envelope__3214EC070B9B06D0");

        entity.ToTable("EnvelopeAddressingStyle");

        entity.Property(e => e.Active).HasDefaultValue(true);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.ValidateLines)
                .HasMaxLength(20)
                .IsUnicode(false);

        entity.HasOne(d => d.Layout).WithMany(p => p.EnvelopeAddressingStyles)
                .HasForeignKey(d => d.LayoutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EnvelopeAddressingStyle_Layout");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<EnvelopeAddressingStyle> entity);
}
