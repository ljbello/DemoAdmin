using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class MerchandisingSortingParameterConfiguration : IEntityTypeConfiguration<MerchandisingSortingParameter>
{
    public void Configure(EntityTypeBuilder<MerchandisingSortingParameter> entity)
    {
        entity.ToTable(tb => tb.HasTrigger("UpdateOnMerchandisingSortingParameters"));

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.ParameterName)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.StoreId).HasDefaultValue(1);

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.MerchandisingSortingParameterCreatedByNavigations).HasForeignKey(d => d.CreatedBy);

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.MerchandisingSortingParameterModifiedByNavigations).HasForeignKey(d => d.ModifiedBy);

        entity.HasOne(d => d.Store).WithMany(p => p.MerchandisingSortingParameters)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MerchandisingSortingParameters_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<MerchandisingSortingParameter> entity);
}
