// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_PS_ORD_HIST_PMT
    public class ViPsOrdHistPmt
    {
        public DateTime BusDat { get; set; } // BUS_DAT
        public long DocId { get; set; } // DOC_ID
        public int PmtSeqNo { get; set; } // PMT_SEQ_NO
        public int SeqNo { get; set; } // SEQ_NO
        public string EventNo { get; set; } // EVENT_NO (length: 15)
        public string StrId { get; set; } // STR_ID (length: 10)
        public string StaId { get; set; } // STA_ID (length: 10)
        public string TktNo { get; set; } // TKT_NO (length: 15)
        public string PmtLinTyp { get; set; } // PMT_LIN_TYP (length: 1)
        public string PmtTyp { get; set; } // PMT_TYP (length: 1)
        public string PayCod { get; set; } // PAY_COD (length: 10)
        public DateTime? PayDat { get; set; } // PAY_DAT
        public byte[] SigImg { get; set; } // SIG_IMG (length: 2147483647)
        public byte[] SigImgVector { get; set; } // SIG_IMG_VECTOR (length: 2147483647)
        public string Swiped { get; set; } // SWIPED (length: 1)
        public string DepLinCopiedToRelDoc { get; set; } // DEP_LIN_COPIED_TO_REL_DOC (length: 1)
        public string FinalPmt { get; set; } // FINAL_PMT (length: 1)
        public string SecureEcommTrx { get; set; } // SECURE_ECOMM_TRX (length: 1)
        public string EdcAuthCod { get; set; } // EDC_AUTH_COD (length: 10)
        public int? RptPrtSeqNo { get; set; } // RPT_PRT_SEQ_NO
        public DateTime? TktDat { get; set; } // TKT_DAT
        public DateTime PostDat { get; set; } // POST_DAT
        public string Descr { get; set; } // DESCR (length: 30)
        public string PayCodTyp { get; set; } // PAY_COD_TYP (length: 1)
        public string PayTyp { get; set; } // PAY_TYP (length: 1)
        public string UseSigCap { get; set; } // USE_SIG_CAP (length: 1)
        public string CurncyCod { get; set; } // CURNCY_COD (length: 10)
        public string CurncyCodDescr { get; set; } // CURNCY_COD_DESCR (length: 30)
        public string IsForeign { get; set; } // IS_FOREIGN (length: 1)
        public decimal Amt { get; set; } // AMT
        public decimal? AbsAmt { get; set; } // ABS_AMT
        public decimal HomeCurncyAmt { get; set; } // HOME_CURNCY_AMT
        public decimal? AbsHomeCurncyAmt { get; set; } // ABS_HOME_CURNCY_AMT
        public decimal ExchLoss { get; set; } // EXCH_LOSS
        public decimal ExchRateNumer { get; set; } // EXCH_RATE_NUMER
        public decimal ExchRateDenom { get; set; } // EXCH_RATE_DENOM
        public double? ExchRate { get; set; } // EXCH_RATE
        public decimal? NetPmtAmt { get; set; } // NET_PMT_AMT
        public decimal? AbsNetPmtAmt { get; set; } // ABS_NET_PMT_AMT
        public decimal OrdAmt { get; set; } // ORD_AMT
        public decimal? NetOrdPmtAmt { get; set; } // NET_ORD_PMT_AMT
        public string GfcNo { get; set; } // GFC_NO (length: 30)
        public string StcNo { get; set; } // STC_NO (length: 30)
        public string StcIsNew { get; set; } // STC_IS_NEW (length: 1)
        public string SvcNo { get; set; } // SVC_NO (length: 30)
        public decimal? SvcBalRemain { get; set; } // SVC_BAL_REMAIN
        public string SvcRefNo { get; set; } // SVC_REF_NO (length: 10)
        public string CrCardNo { get; set; } // CR_CARD_NO (length: 30)
        public string CrCardNoMsk { get; set; } // CR_CARD_NO_MSK (length: 30)
        public byte[] CrCardNoEnc { get; set; } // CR_CARD_NO_ENC (length: 32)
        public byte? CrCardNoKid { get; set; } // CR_CARD_NO_KID
        public string CrCardNam { get; set; } // CR_CARD_NAM (length: 30)
        public DateTime? CrCardExpDat { get; set; } // CR_CARD_EXP_DAT
        public decimal? BalRemain { get; set; } // BAL_REMAIN
        public string AvsAdrs { get; set; } // AVS_ADRS (length: 20)
        public string AvsZipCod { get; set; } // AVS_ZIP_COD (length: 9)
        public string AvsCod { get; set; } // AVS_COD (length: 1)
        public string SkipAvs { get; set; } // SKIP_AVS (length: 1)
        public string CvvCod { get; set; } // CVV_COD (length: 1)
        public string SkipCvv { get; set; } // SKIP_CVV (length: 1)
        public string IsPurchCard { get; set; } // IS_PURCH_CARD (length: 1)
        public string AvsEntd { get; set; } // AVS_ENTD (length: 1)
        public string ChkAcctNo { get; set; } // CHK_ACCT_NO (length: 25)
        public string ChkTransitNo { get; set; } // CHK_TRANSIT_NO (length: 20)
        public string ChkNo { get; set; } // CHK_NO (length: 10)
        public string ChkDrivLicNo { get; set; } // CHK_DRIV_LIC_NO (length: 30)
        public string ChkDrivLicState { get; set; } // CHK_DRIV_LIC_STATE (length: 10)
        public DateTime? ChkBirthDat { get; set; } // CHK_BIRTH_DAT
        public string Ref1 { get; set; } // REF_1 (length: 50)
        public string Prompt1 { get; set; } // PROMPT_1 (length: 15)
        public string Ref2 { get; set; } // REF_2 (length: 50)
        public string Prompt2 { get; set; } // PROMPT_2 (length: 15)
        public string Ref3 { get; set; } // REF_3 (length: 50)
        public string Prompt3 { get; set; } // PROMPT_3 (length: 15)
        public DateTime? BusDatExt { get; set; } // BUS_DAT_EXT
        public long? DocIdExt { get; set; } // DOC_ID_EXT
        public int? PmtSeqNoExt { get; set; } // PMT_SEQ_NO_EXT
    }

}
// </auto-generated>
