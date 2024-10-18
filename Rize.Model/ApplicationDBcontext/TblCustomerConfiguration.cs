using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCustomerConfiguration : IEntityTypeConfiguration<TblCustomer>
{
    public void Configure(EntityTypeBuilder<TblCustomer> entity)
    {
        entity.HasKey(e => e.CusCustomerId).HasName("tblCustomers_PK");

        entity.ToTable("tblCustomers", tb => tb.HasTrigger("tblCustomers_UpdateDate"));

        entity.HasIndex(e => new { e.CusEmail, e.CusCustomerId }, "_dta_index_tblCustomers_7_749297779__K5_K1");

        entity.HasIndex(e => new { e.CusCustomerId, e.StoStoreId, e.CusFirstName, e.CusLastName, e.CusEmail }, "tblCustomers_IX1");

        entity.HasIndex(e => new { e.CusCustomerId, e.StoStoreId, e.CusEmail }, "tblCustomers_IX2");

        entity.HasIndex(e => e.CusFirstName, "tblCustomers_IX3");

        entity.HasIndex(e => e.CusEmail, "tblCustomers_IX4");

        entity.Property(e => e.CusCustomerId).HasColumnName("Cus__CustomerID");
        entity.Property(e => e.CusAnonymous).HasColumnName("Cus__Anonymous");
        entity.Property(e => e.CusBadAddressTemp).HasColumnName("Cus__BadAddress_TEMP");
        entity.Property(e => e.CusBadEmailAddress).HasColumnName("Cus__BadEmailAddress");
        entity.Property(e => e.CusCustomerType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cus__CustomerType");
        entity.Property(e => e.CusDateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Cus__DateCreated");
        entity.Property(e => e.CusDateSendEmailNewsChanged)
                .HasColumnType("datetime")
                .HasColumnName("Cus__DateSendEmailNewsChanged");
        entity.Property(e => e.CusEmail)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Cus__Email");
        entity.Property(e => e.CusFirstName)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Cus__FirstName");
        entity.Property(e => e.CusHtmlemailFormat).HasColumnName("Cus__HTMLEmailFormat");
        entity.Property(e => e.CusInterestAnniversary).HasColumnName("Cus__Interest_Anniversary");
        entity.Property(e => e.CusInterestBaby).HasColumnName("Cus__Interest_Baby");
        entity.Property(e => e.CusInterestBusinessGreetings).HasColumnName("Cus__Interest_BusinessGreetings");
        entity.Property(e => e.CusInterestBusinessStationery).HasColumnName("Cus__Interest_BusinessStationery");
        entity.Property(e => e.CusInterestGraduation).HasColumnName("Cus__Interest_Graduation");
        entity.Property(e => e.CusInterestOffice).HasColumnName("Cus__Interest_Office");
        entity.Property(e => e.CusInterestOtherInvitations).HasColumnName("Cus__Interest_OtherInvitations");
        entity.Property(e => e.CusInterestPersonalStationery).HasColumnName("Cus__Interest_PersonalStationery");
        entity.Property(e => e.CusInterestWedding).HasColumnName("Cus__Interest_Wedding");
        entity.Property(e => e.CusLastName)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Cus__LastName");
        entity.Property(e => e.CusNotes)
                .HasMaxLength(4096)
                .IsUnicode(false)
                .HasColumnName("Cus__Notes");
        entity.Property(e => e.CusProspect).HasColumnName("Cus__Prospect");
        entity.Property(e => e.CusSendEmailNewsletters).HasColumnName("Cus__SendEmailNewsletters");
        entity.Property(e => e.CusSendPaperMail)
                .HasDefaultValue(true)
                .HasColumnName("Cus__SendPaperMail");
        entity.Property(e => e.CusSolicitPhone)
                .HasDefaultValue(true)
                .HasColumnName("Cus__SolicitPhone");
        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");
        entity.Property(e => e.UpdateDate).HasColumnType("datetime");

        entity.HasOne(d => d.StoStore).WithMany(p => p.TblCustomers)
                .HasForeignKey(d => d.StoStoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCustomers_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCustomer> entity);
}
