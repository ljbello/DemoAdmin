using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblProFuConfiguration : IEntityTypeConfiguration<TblProFu>
{
    public void Configure(EntityTypeBuilder<TblProFu> entity)
    {
        entity
                .HasNoKey()
                .ToTable("tblProFU");

        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductID");
        entity.Property(e => e.ProStaProductStatusId).HasColumnName("ProSta__ProductStatusID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblProFu> entity);
}
