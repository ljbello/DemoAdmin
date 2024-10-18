using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblSearchTermConfiguration : IEntityTypeConfiguration<TblSearchTerm>
{
    public void Configure(EntityTypeBuilder<TblSearchTerm> entity)
    {
        entity.HasKey(e => e.SeaTerSearchTermId);

        entity.ToTable("tblSearchTerms");

        entity.Property(e => e.SeaTerSearchTermId).HasColumnName("SeaTer__SearchTermID");
        entity.Property(e => e.SeaTerSearchCount).HasColumnName("SeaTer__SearchCount");
        entity.Property(e => e.SeaTerSearchTerm)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SeaTer__SearchTerm");
        entity.Property(e => e.StoStoreId)
                .HasDefaultValue(1)
                .HasColumnName("Sto__StoreID");

        entity.HasOne(d => d.StoStore).WithMany(p => p.TblSearchTerms)
                .HasForeignKey(d => d.StoStoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSearchTerms_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblSearchTerm> entity);
}
