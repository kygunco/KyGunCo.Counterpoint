// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PS_TKT_HIST_PMT
    public class ViPsTktHistPmtConfiguration : IEntityTypeConfiguration<ViPsTktHistPmt>
    {
        public void Configure(EntityTypeBuilder<ViPsTktHistPmt> builder)
        {
            builder.ToView("VI_PS_TKT_HIST_PMT", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.BusDat).HasColumnName(@"BUS_DAT").HasColumnType("smalldatetime").IsRequired();
            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.PmtSeqNo).HasColumnName(@"PMT_SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.EventNo).HasColumnName(@"EVENT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.PmtLinTyp).HasColumnName(@"PMT_LIN_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PmtTyp).HasColumnName(@"PMT_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PayCod).HasColumnName(@"PAY_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PayDat).HasColumnName(@"PAY_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.SigImg).HasColumnName(@"SIG_IMG").HasColumnType("image(2147483647)").IsRequired(false).HasMaxLength(2147483647);
            builder.Property(x => x.SigImgVector).HasColumnName(@"SIG_IMG_VECTOR").HasColumnType("image(2147483647)").IsRequired(false).HasMaxLength(2147483647);
            builder.Property(x => x.FinalPmt).HasColumnName(@"FINAL_PMT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Swiped).HasColumnName(@"SWIPED").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SecureEcommTrx).HasColumnName(@"SECURE_ECOMM_TRX").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EdcAuthCod).HasColumnName(@"EDC_AUTH_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.EbtBalRemain).HasColumnName(@"EBT_BAL_REMAIN").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.TktDat).HasColumnName(@"TKT_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.PostDat).HasColumnName(@"POST_DAT").HasColumnType("smalldatetime").IsRequired();
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PayCodTyp).HasColumnName(@"PAY_COD_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PayTyp).HasColumnName(@"PAY_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseSigCap).HasColumnName(@"USE_SIG_CAP").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CurncyCod).HasColumnName(@"CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CurncyCodDescr).HasColumnName(@"CURNCY_COD_DESCR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.IsForeign).HasColumnName(@"IS_FOREIGN").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Amt).HasColumnName(@"AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AbsAmt).HasColumnName(@"ABS_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.HomeCurncyAmt).HasColumnName(@"HOME_CURNCY_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AbsHomeCurncyAmt).HasColumnName(@"ABS_HOME_CURNCY_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ExchLoss).HasColumnName(@"EXCH_LOSS").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.ExchRateNumer).HasColumnName(@"EXCH_RATE_NUMER").HasColumnType("money").IsRequired();
            builder.Property(x => x.ExchRateDenom).HasColumnName(@"EXCH_RATE_DENOM").HasColumnType("money").IsRequired();
            builder.Property(x => x.ExchRate).HasColumnName(@"EXCH_RATE").HasColumnType("float").IsRequired(false);
            builder.Property(x => x.NetPmtAmt).HasColumnName(@"NET_PMT_AMT").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.AbsNetPmtAmt).HasColumnName(@"ABS_NET_PMT_AMT").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.RoundGainLoss).HasColumnName(@"ROUND_GAIN_LOSS").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.HomeCurncyRoundGainLoss).HasColumnName(@"HOME_CURNCY_ROUND_GAIN_LOSS").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.TipAmt).HasColumnName(@"TIP_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.GfcNo).HasColumnName(@"GFC_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.StcNo).HasColumnName(@"STC_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.StcIsNew).HasColumnName(@"STC_IS_NEW").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SvcNo).HasColumnName(@"SVC_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.SvcBalRemain).HasColumnName(@"SVC_BAL_REMAIN").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SvcRefNo).HasColumnName(@"SVC_REF_NO").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LoyPgmCod).HasColumnName(@"LOY_PGM_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.LoyPtsRdm).HasColumnName(@"LOY_PTS_RDM").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.CrCardNo).HasColumnName(@"CR_CARD_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.CrCardNoMsk).HasColumnName(@"CR_CARD_NO_MSK").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.CrCardNoEnc).HasColumnName(@"CR_CARD_NO_ENC").HasColumnType("varbinary(32)").IsRequired(false).HasMaxLength(32);
            builder.Property(x => x.CrCardNoKid).HasColumnName(@"CR_CARD_NO_KID").HasColumnType("tinyint").IsRequired(false);
            builder.Property(x => x.CrCardNam).HasColumnName(@"CR_CARD_NAM").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.CrCardExpDat).HasColumnName(@"CR_CARD_EXP_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.BalRemain).HasColumnName(@"BAL_REMAIN").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.UniqueTransId).HasColumnName(@"UNIQUE_TRANS_ID").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.ProcessorTransId).HasColumnName(@"PROCESSOR_TRANS_ID").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.AvsAdrs).HasColumnName(@"AVS_ADRS").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.AvsZipCod).HasColumnName(@"AVS_ZIP_COD").HasColumnType("varchar(9)").IsRequired(false).IsUnicode(false).HasMaxLength(9);
            builder.Property(x => x.AvsCod).HasColumnName(@"AVS_COD").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SkipAvs).HasColumnName(@"SKIP_AVS").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CvvCod).HasColumnName(@"CVV_COD").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SkipCvv).HasColumnName(@"SKIP_CVV").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.IsPurchCard).HasColumnName(@"IS_PURCH_CARD").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.AvsEntd).HasColumnName(@"AVS_ENTD").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ChkAcctNo).HasColumnName(@"CHK_ACCT_NO").HasColumnType("varchar(25)").IsRequired(false).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.ChkTransitNo).HasColumnName(@"CHK_TRANSIT_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.ChkNo).HasColumnName(@"CHK_NO").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ChkDrivLicNo).HasColumnName(@"CHK_DRIV_LIC_NO").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.ChkDrivLicState).HasColumnName(@"CHK_DRIV_LIC_STATE").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.ChkBirthDat).HasColumnName(@"CHK_BIRTH_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.Ref1).HasColumnName(@"REF_1").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Prompt1).HasColumnName(@"PROMPT_1").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Ref2).HasColumnName(@"REF_2").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Prompt2).HasColumnName(@"PROMPT_2").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Ref3).HasColumnName(@"REF_3").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Prompt3).HasColumnName(@"PROMPT_3").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.BusDatExt).HasColumnName(@"BUS_DAT_EXT").HasColumnType("smalldatetime").IsRequired(false);
            builder.Property(x => x.DocIdExt).HasColumnName(@"DOC_ID_EXT").HasColumnType("bigint").IsRequired(false);
            builder.Property(x => x.PmtSeqNoExt).HasColumnName(@"PMT_SEQ_NO_EXT").HasColumnType("int").IsRequired(false);
        }
    }

}
// </auto-generated>
