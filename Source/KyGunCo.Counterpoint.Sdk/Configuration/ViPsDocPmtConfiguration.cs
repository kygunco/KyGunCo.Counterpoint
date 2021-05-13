// <auto-generated>

using KyGunCo.Counterpoint.Sdk.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KyGunCo.Counterpoint.Sdk.Configuration
{
    // VI_PS_DOC_PMT
    public class ViPsDocPmtConfiguration : IEntityTypeConfiguration<ViPsDocPmt>
    {
        public void Configure(EntityTypeBuilder<ViPsDocPmt> builder)
        {
            builder.ToView("VI_PS_DOC_PMT", "dbo");
            builder.HasNoKey();

            builder.Property(x => x.DocId).HasColumnName(@"DOC_ID").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.PmtSeqNo).HasColumnName(@"PMT_SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.SeqNo).HasColumnName(@"SEQ_NO").HasColumnType("int").IsRequired();
            builder.Property(x => x.StrId).HasColumnName(@"STR_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.StaId).HasColumnName(@"STA_ID").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TktNo).HasColumnName(@"TKT_NO").HasColumnType("varchar(15)").IsRequired().IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.PmtLinTyp).HasColumnName(@"PMT_LIN_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PmtTyp).HasColumnName(@"PMT_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PayCod).HasColumnName(@"PAY_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.PayDat).HasColumnName(@"PAY_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.SigImg).HasColumnName(@"SIG_IMG").HasColumnType("image(2147483647)").IsRequired(false).HasMaxLength(2147483647);
            builder.Property(x => x.SigImgVector).HasColumnName(@"SIG_IMG_VECTOR").HasColumnType("image(2147483647)").IsRequired(false).HasMaxLength(2147483647);
            builder.Property(x => x.Swiped).HasColumnName(@"SWIPED").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.DepLinCopiedToRelDoc).HasColumnName(@"DEP_LIN_COPIED_TO_REL_DOC").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.FinalPmt).HasColumnName(@"FINAL_PMT").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.SecureEcommTrx).HasColumnName(@"SECURE_ECOMM_TRX").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EdcAuthCod).HasColumnName(@"EDC_AUTH_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.EdcAuthFlg).HasColumnName(@"EDC_AUTH_FLG").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.EbtBalRemain).HasColumnName(@"EBT_BAL_REMAIN").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.RptPrtSeqNo).HasColumnName(@"RPT_PRT_SEQ_NO").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Descr).HasColumnName(@"DESCR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.PayCodTyp).HasColumnName(@"PAY_COD_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.PayTyp).HasColumnName(@"PAY_TYP").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.OpnDrw).HasColumnName(@"OPN_DRW").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.UseSigCap).HasColumnName(@"USE_SIG_CAP").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CurncyCod).HasColumnName(@"CURNCY_COD").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.CurncyCodDescr).HasColumnName(@"CURNCY_COD_DESCR").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.IsForeign).HasColumnName(@"IS_FOREIGN").HasColumnType("varchar(1)").IsRequired().IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Amt).HasColumnName(@"AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AbsAmt).HasColumnName(@"ABS_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.HomeCurncyAmt).HasColumnName(@"HOME_CURNCY_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.AbsHomeCurncyAmt).HasColumnName(@"ABS_HOME_CURNCY_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ExchLoss).HasColumnName(@"EXCH_LOSS").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.ExchRateNumer).HasColumnName(@"EXCH_RATE_NUMER").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.ExchRateDenom).HasColumnName(@"EXCH_RATE_DENOM").HasColumnType("decimal(15,4)").IsRequired();
            builder.Property(x => x.ExchRate).HasColumnName(@"EXCH_RATE").HasColumnType("float").IsRequired(false);
            builder.Property(x => x.NetPmtAmt).HasColumnName(@"NET_PMT_AMT").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.AbsNetPmtAmt).HasColumnName(@"ABS_NET_PMT_AMT").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.TipAmt).HasColumnName(@"TIP_AMT").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.SalAmt).HasColumnName(@"SAL_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalHomeCurncyAmt).HasColumnName(@"SAL_HOME_CURNCY_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.SalExchLoss).HasColumnName(@"SAL_EXCH_LOSS").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdAmt).HasColumnName(@"ORD_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdHomeCurncyAmt).HasColumnName(@"ORD_HOME_CURNCY_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.OrdExchLoss).HasColumnName(@"ORD_EXCH_LOSS").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.NetOrdPmtAmt).HasColumnName(@"NET_ORD_PMT_AMT").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.AbsOrdAmt).HasColumnName(@"ABS_ORD_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.AbsOrdHomeCurncyAmt).HasColumnName(@"ABS_ORD_HOME_CURNCY_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.AbsNetOrdPmtAmt).HasColumnName(@"ABS_NET_ORD_PMT_AMT").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.LwyAmt).HasColumnName(@"LWY_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LwyHomeCurncyAmt).HasColumnName(@"LWY_HOME_CURNCY_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.LwyExchLoss).HasColumnName(@"LWY_EXCH_LOSS").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.NetLwyPmtAmt).HasColumnName(@"NET_LWY_PMT_AMT").HasColumnType("decimal(16,2)").IsRequired(false);
            builder.Property(x => x.AbsLwyAmt).HasColumnName(@"ABS_LWY_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.AbsLwyHomeCurncyAmt).HasColumnName(@"ABS_LWY_HOME_CURNCY_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.AbsNetLwyPmtAmt).HasColumnName(@"ABS_NET_LWY_PMT_AMT").HasColumnType("decimal(16,2)").IsRequired(false);
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
            builder.Property(x => x.CrCardExpDat).HasColumnName(@"CR_CARD_EXP_DAT").HasColumnType("smalldatetime").IsRequired(false);
            builder.Property(x => x.BalRemain).HasColumnName(@"BAL_REMAIN").HasColumnType("decimal(15,2)").IsRequired(false);
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
            builder.Property(x => x.Prompt1Req).HasColumnName(@"PROMPT_1_REQ").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Ref1).HasColumnName(@"REF_1").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Prompt1).HasColumnName(@"PROMPT_1").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Prompt2Req).HasColumnName(@"PROMPT_2_REQ").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Ref2).HasColumnName(@"REF_2").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Prompt2).HasColumnName(@"PROMPT_2").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Prompt3Req).HasColumnName(@"PROMPT_3_REQ").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.Ref3).HasColumnName(@"REF_3").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Prompt3).HasColumnName(@"PROMPT_3").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.TransTyp).HasColumnName(@"TRANS_TYP").HasColumnType("varchar(2)").IsRequired(false).IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.UniqueTransId).HasColumnName(@"UNIQUE_TRANS_ID").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.TransStat).HasColumnName(@"TRANS_STAT").HasColumnType("varchar(2)").IsRequired(false).IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.RcptAuthCod).HasColumnName(@"RCPT_AUTH_COD").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.TransApproved).HasColumnName(@"TRANS_APPROVED").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.ProcessorTransId).HasColumnName(@"PROCESSOR_TRANS_ID").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.RcptCardNoMsk).HasColumnName(@"RCPT_CARD_NO_MSK").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.RcptAcctTyp).HasColumnName(@"RCPT_ACCT_TYP").HasColumnType("varchar(2)").IsRequired(false).IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.RcptCardTyp).HasColumnName(@"RCPT_CARD_TYP").HasColumnType("varchar(2)").IsRequired(false).IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.RcptTransDat).HasColumnName(@"RCPT_TRANS_DAT").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.RcptTransTim).HasColumnName(@"RCPT_TRANS_TIM").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.ProcessorRefNo).HasColumnName(@"PROCESSOR_REF_NO").HasColumnType("varchar(20)").IsRequired(false).IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.RcptAmt).HasColumnName(@"RCPT_AMT").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.RcptLang).HasColumnName(@"RCPT_LANG").HasColumnType("varchar(2)").IsRequired(false).IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.ProcessorMsg).HasColumnName(@"PROCESSOR_MSG").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.ErrorMsg).HasColumnName(@"ERROR_MSG").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.RcptStrId).HasColumnName(@"RCPT_STR_ID").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.RcptTermId).HasColumnName(@"RCPT_TERM_ID").HasColumnType("varchar(30)").IsRequired(false).IsUnicode(false).HasMaxLength(30);
            builder.Property(x => x.RcptMsg).HasColumnName(@"RCPT_MSG").HasColumnType("varchar(250)").IsRequired(false).IsUnicode(false).HasMaxLength(250);
            builder.Property(x => x.EntryMeth).HasColumnName(@"ENTRY_METH").HasColumnType("varchar(2)").IsRequired(false).IsUnicode(false).HasMaxLength(2);
            builder.Property(x => x.AvsResult).HasColumnName(@"AVS_RESULT").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CvvResult).HasColumnName(@"CVV_RESULT").HasColumnType("varchar(1)").IsRequired(false).IsUnicode(false).HasMaxLength(1);
            builder.Property(x => x.CardBalRemain).HasColumnName(@"CARD_BAL_REMAIN").HasColumnType("decimal(15,2)").IsRequired(false);
            builder.Property(x => x.ProcessorClientRcpt).HasColumnName(@"PROCESSOR_CLIENT_RCPT").HasColumnType("varchar(7000)").IsRequired(false).IsUnicode(false).HasMaxLength(7000);
            builder.Property(x => x.ProcessorMerchRcpt).HasColumnName(@"PROCESSOR_MERCH_RCPT").HasColumnType("varchar(7000)").IsRequired(false).IsUnicode(false).HasMaxLength(7000);
            builder.Property(x => x.DocIdExt).HasColumnName(@"DOC_ID_EXT").HasColumnType("bigint").IsRequired(false);
            builder.Property(x => x.PmtSeqNoExt).HasColumnName(@"PMT_SEQ_NO_EXT").HasColumnType("int").IsRequired(false);
        }
    }

}
// </auto-generated>