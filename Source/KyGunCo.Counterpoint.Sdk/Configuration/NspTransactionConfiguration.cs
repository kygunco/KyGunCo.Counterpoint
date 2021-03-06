// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // NSP_Transaction
    public class NspTransactionConfiguration : IEntityTypeConfiguration<NspTransaction>
    {
        public void Configure(EntityTypeBuilder<NspTransaction> builder)
        {
            builder.ToTable("NSP_Transaction", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_NSP_Transaction").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.MerchId).HasColumnName(@"merchID").HasColumnType("varchar(50)").IsRequired().IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Ptrannum).HasColumnName(@"ptrannum").HasColumnType("varchar(30)").IsRequired().IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.IsSettled).HasColumnName(@"isSettled").HasColumnType("bit").IsRequired();
            builder.Property(x => x.Ttid).HasColumnName(@"ttid").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.MsoftCode).HasColumnName(@"msoft_code").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PhardCode).HasColumnName(@"phard_code").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.NspType).HasColumnName(@"nsp_type").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.NspProc).HasColumnName(@"nsp_proc").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.Entrymode).HasColumnName(@"entrymode").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Txnstatus).HasColumnName(@"txnstatus").HasColumnType("varchar(200)").IsRequired(false).IsUnicode(false).HasMaxLength(200);
            builder.Property(x => x.Tranflags).HasColumnName(@"tranflags").HasColumnType("varchar(200)").IsRequired(false).IsUnicode(false).HasMaxLength(200);
            builder.Property(x => x.Capture).HasColumnName(@"capture").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.NspCard).HasColumnName(@"nsp_card").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.Pclevel).HasColumnName(@"pclevel").HasColumnType("int").IsRequired();
            builder.Property(x => x.Cardlevel).HasColumnName(@"cardlevel").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Abaroute).HasColumnName(@"abaroute").HasColumnType("varchar(200)").IsRequired(false).IsUnicode(false).HasMaxLength(200);
            builder.Property(x => x.Account).HasColumnName(@"account").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.Expdate).HasColumnName(@"expdate").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Checknum).HasColumnName(@"checknum").HasColumnType("int").IsRequired();
            builder.Property(x => x.NspTimestamp).HasColumnName(@"nsp_timestamp").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Startdate).HasColumnName(@"startdate").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Issuenum).HasColumnName(@"issuenum").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.Accounttype).HasColumnName(@"accounttype").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Amount).HasColumnName(@"amount").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.Examount).HasColumnName(@"examount").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.Tax).HasColumnName(@"tax").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.Cashback).HasColumnName(@"cashback").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.Authnum).HasColumnName(@"authnum").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.Stan).HasColumnName(@"stan").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.Batch).HasColumnName(@"batch").HasColumnType("int").IsRequired();
            builder.Property(x => x.Item).HasColumnName(@"item").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.Cardholdername).HasColumnName(@"cardholdername").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Avs).HasColumnName(@"avs").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Cv).HasColumnName(@"cv").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.Clerkid).HasColumnName(@"clerkid").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Stationid).HasColumnName(@"stationid").HasColumnType("varchar(200)").IsRequired(false).IsUnicode(false).HasMaxLength(200);
            builder.Property(x => x.Comments).HasColumnName(@"comments").HasColumnType("varchar(200)").IsRequired(false).IsUnicode(false).HasMaxLength(200);
            builder.Property(x => x.Divisionnum).HasColumnName(@"divisionnum").HasColumnType("varchar(200)").IsRequired(false).IsUnicode(false).HasMaxLength(200);
            builder.Property(x => x.Promoid).HasColumnName(@"promoid").HasColumnType("varchar(200)").IsRequired(false).IsUnicode(false).HasMaxLength(200);
            builder.Property(x => x.Descmerch).HasColumnName(@"descmerch").HasColumnType("varchar(200)").IsRequired(false).IsUnicode(false).HasMaxLength(200);
            builder.Property(x => x.Ordernum).HasColumnName(@"ordernum").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.Custref).HasColumnName(@"custref").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.Discountamount).HasColumnName(@"discountamount").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.Freightamount).HasColumnName(@"freightamount").HasColumnType("float").IsRequired();
            builder.Property(x => x.Dutyamount).HasColumnName(@"dutyamount").HasColumnType("float").IsRequired();
            builder.Property(x => x.Shipzip).HasColumnName(@"shipzip").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Shipcountry).HasColumnName(@"shipcountry").HasColumnType("varchar(80)").IsRequired(false).IsUnicode(false).HasMaxLength(80);
            builder.Property(x => x.L3Num).HasColumnName(@"l3num").HasColumnType("int").IsRequired();
            builder.Property(x => x.RawCode).HasColumnName(@"raw_code").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.RawAvs).HasColumnName(@"raw_avs").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RawCv).HasColumnName(@"raw_cv").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.RawCardlevel).HasColumnName(@"raw_cardlevel").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Reversible).HasColumnName(@"reversible").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.Reasoncode).HasColumnName(@"reasoncode").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.ReportTimestamp).HasColumnName(@"ReportTimestamp").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>
