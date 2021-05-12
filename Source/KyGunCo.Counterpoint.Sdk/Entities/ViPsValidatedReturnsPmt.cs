// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_PS_VALIDATED_RETURNS_PMT
    public class ViPsValidatedReturnsPmt
    {
        public DateTime? BusDat { get; set; } // BUS_DAT
        public long DocId { get; set; } // DOC_ID
        public int PmtSeqNo { get; set; } // PMT_SEQ_NO
        public string PayCod { get; set; } // PAY_COD (length: 10)
        public string PmtLinTyp { get; set; } // PMT_LIN_TYP (length: 1)
        public string PmtTyp { get; set; } // PMT_TYP (length: 1)
        public string PayCodTyp { get; set; } // PAY_COD_TYP (length: 1)
        public string Descr { get; set; } // DESCR (length: 30)
        public string PayTyp { get; set; } // PAY_TYP (length: 1)
        public decimal Amt { get; set; } // AMT
        public string CurncyCod { get; set; } // CURNCY_COD (length: 10)
        public decimal HomeCurncyAmt { get; set; } // HOME_CURNCY_AMT
        public decimal ExchLoss { get; set; } // EXCH_LOSS
        public decimal ExchRateNumer { get; set; } // EXCH_RATE_NUMER
        public decimal ExchRateDenom { get; set; } // EXCH_RATE_DENOM
        public string IsForeign { get; set; } // IS_FOREIGN (length: 1)
        public string CrCardNoMsk { get; set; } // CR_CARD_NO_MSK (length: 30)
        public byte[] CrCardNoEnc { get; set; } // CR_CARD_NO_ENC (length: 32)
        public byte? CrCardNoKid { get; set; } // CR_CARD_NO_KID
        public string CrCardNam { get; set; } // CR_CARD_NAM (length: 30)
        public DateTime? CrCardExpDat { get; set; } // CR_CARD_EXP_DAT
        public string UniqueTransId { get; set; } // UNIQUE_TRANS_ID (length: 20)
        public string ProcessorTransId { get; set; } // PROCESSOR_TRANS_ID (length: 20)
        public string AvsAdrs { get; set; } // AVS_ADRS (length: 20)
        public string AvsZipCod { get; set; } // AVS_ZIP_COD (length: 9)
        public string IsPurchCard { get; set; } // IS_PURCH_CARD (length: 1)
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
        public int? LoyPtsRdm { get; set; } // LOY_PTS_RDM
    }

}
// </auto-generated>
