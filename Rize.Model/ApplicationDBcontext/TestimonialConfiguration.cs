using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TestimonialConfiguration : IEntityTypeConfiguration<Testimonial>
{
    public void Configure(EntityTypeBuilder<Testimonial> entity)
    {
        entity.ToTable("Testimonial");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Active).HasDefaultValue(true);
        entity.Property(e => e.ByLocation).HasMaxLength(150);
        entity.Property(e => e.ByName).HasMaxLength(150);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.CustomerPhotoPath).HasMaxLength(50);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.QuoteType).HasMaxLength(300);
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.TestimonialText).HasMaxLength(800);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Testimonial> entity);
}
