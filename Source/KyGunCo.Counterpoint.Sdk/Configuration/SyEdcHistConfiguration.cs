// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // SY_EDC_HIST
    public class SyEdcHistConfiguration : IEntityTypeConfiguration<SyEdcHist>
    {
        public void Configure(EntityTypeBuilder<SyEdcHist> builder)
        {
            builder.ToTable("SY_EDC_HIST", "dbo");
            builder.HasKey(x => new { x.BusDat, x.TrxSrc, x.DocId, x.SeqNo }).HasName("PK_SY_EDC_HIST").IsClustered();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.TrxSrc).HasColumnName(@"TRX_SRC").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1).ValueGeneratedNever();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.PsBusDat).HasColumnName(@"PS_BUS_DAT").HasColumnType("smalldatetime").IsRequired(false);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.DrwId).HasColumnName(@"DRW_ID").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PayCod).HasColumnName(@"PAY_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PayTyp).HasColumnName(@"PAY_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Amt).HasColumnName(@"AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TaxAmt).HasColumnName(@"TAX_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.CustPoNo).HasColumnName(@"CUST_PO_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.IndustryTyp).HasColumnName(@"INDUSTRY_TYP").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ChkAcctNo).HasColumnName(@"CHK_ACCT_NO").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.ChkTransitNo).HasColumnName(@"CHK_TRANSIT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.ChkNo).HasColumnName(@"CHK_NO").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ChkDrivLicNo).HasColumnName(@"CHK_DRIV_LIC_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ChkDrivLicState).HasColumnName(@"CHK_DRIV_LIC_STATE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ChkBirthDat).HasColumnName(@"CHK_BIRTH_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.CrCardNo).HasColumnName(@"CR_CARD_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.CrCardNoMsk).HasColumnName(@"CR_CARD_NO_MSK").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.CrCardNam).HasColumnName(@"CR_CARD_NAM").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.CrCardExpDat).HasColumnName(@"CR_CARD_EXP_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Swiped).HasColumnName(@"SWIPED").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Forced).HasColumnName(@"FORCED").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AvsAdrs).HasColumnName(@"AVS_ADRS").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.AvsZipCod).HasColumnName(@"AVS_ZIP_COD").HasColumnType("varchar(9)").IsRequired(false).IsUnicode(false).HasMaxLength(9);
            builder.Property(x => x.EdcAuthCod).HasColumnName(@"EDC_AUTH_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.AvsCod).HasColumnName(@"AVS_COD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CvvCod).HasColumnName(@"CVV_COD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.IsVoid).HasColumnName(@"IS_VOID").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.TransDat).HasColumnName(@"TRANS_DAT").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.TransTim).HasColumnName(@"TRANS_TIM").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.CardTyp).HasColumnName(@"CARD_TYP").HasColumnType("varchar(2)").IsRequired().IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.IsPurchCard).HasColumnName(@"IS_PURCH_CARD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CrCardNoEnc).HasColumnName(@"CR_CARD_NO_ENC").HasColumnType("varbinary(32)").IsRequired(false).HasMaxLength(32);
            builder.Property(x => x.CrCardNoKid).HasColumnName(@"CR_CARD_NO_KID").HasColumnType("tinyint").IsRequired(false);
            builder.Property(x => x.BatchNo).HasColumnName(@"BATCH_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);

            builder.HasIndex(x => new { x.TransDat, x.TransTim, x.BusDat, x.TrxSrc, x.DocId, x.SeqNo }).HasDatabaseName("SY_EDC_HIST_X1");
            builder.HasIndex(x => new { x.TrxSrc, x.StrId, x.DrwId, x.TransDat, x.TransTim, x.BusDat, x.DocId, x.SeqNo }).HasDatabaseName("SY_EDC_HIST_X2");
            builder.HasIndex(x => new { x.TrxSrc, x.DocId, x.SeqNo, x.BusDat }).HasDatabaseName("SY_EDC_HIST_X3");
            builder.HasIndex(x => new { x.StrId, x.BusDat }).HasDatabaseName("SY_EDC_HIST_X4");
        }
    }

}
// </auto-generated>