// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // SY_EDC_TRX
    public class SyEdcTrx
    {
        public string TrxSrc { get; set; } = "T"; // TRX_SRC (Primary key) (length: 1)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public int SeqNo { get; set; } // SEQ_NO (Primary key)
        public DateTime? PsBusDat { get; set; } // PS_BUS_DAT
        public string StrId { get; set; } // STR_ID (length: 10)
        public string StaId { get; set; } // STA_ID (length: 10)
        public string TktNo { get; set; } // TKT_NO (length: 15)
        public string DrwId { get; set; } // DRW_ID (length: 10)
        public string PayCod { get; set; } // PAY_COD (length: 10)
        public string PayTyp { get; set; } // PAY_TYP (length: 1)
        public decimal? Amt { get; set; } = 0m; // AMT
        public decimal? TaxAmt { get; set; } = 0m; // TAX_AMT
        public string CustPoNo { get; set; } // CUST_PO_NO (length: 20)
        public string IndustryTyp { get; set; } // INDUSTRY_TYP (length: 1)
        public string ChkMicrData { get; set; } // CHK_MICR_DATA (length: 50)
        public string ChkAcctNo { get; set; } // CHK_ACCT_NO (length: 25)
        public string ChkTransitNo { get; set; } // CHK_TRANSIT_NO (length: 20)
        public string ChkNo { get; set; } // CHK_NO (length: 10)
        public string ChkDrivLicNo { get; set; } // CHK_DRIV_LIC_NO (length: 30)
        public string ChkDrivLicState { get; set; } // CHK_DRIV_LIC_STATE (length: 10)
        public DateTime? ChkBirthDat { get; set; } // CHK_BIRTH_DAT
        public string CrCardTrackData { get; set; } // CR_CARD_TRACK_DATA (length: 100)
        public string CrCardNo { get; set; } // CR_CARD_NO (length: 30)
        public string CrCardNoMsk { get; set; } // CR_CARD_NO_MSK (length: 30)
        public string CrCardNam { get; set; } // CR_CARD_NAM (length: 30)
        public DateTime? CrCardExpDat { get; set; } // CR_CARD_EXP_DAT
        public string Swiped { get; set; } = "N"; // SWIPED (length: 1)
        public string Forced { get; set; } = "N"; // FORCED (length: 1)
        public string AvsAdrs { get; set; } // AVS_ADRS (length: 20)
        public string AvsZipCod { get; set; } // AVS_ZIP_COD (length: 9)
        public string EdcAuthCod { get; set; } // EDC_AUTH_COD (length: 10)
        public string AvsCod { get; set; } = "!"; // AVS_COD (length: 1)
        public string CvvCod { get; set; } = "!"; // CVV_COD (length: 1)
        public string IsVoid { get; set; } = "N"; // IS_VOID (length: 1)
        public string EdcAuthResp { get; set; } // EDC_AUTH_RESP (length: 80)
        public DateTime TransDat { get; set; } // TRANS_DAT
        public DateTime TransTim { get; set; } // TRANS_TIM
        public string CardTyp { get; set; } = "??"; // CARD_TYP (length: 2)
        public string IsPurchCard { get; set; } = "N"; // IS_PURCH_CARD (length: 1)
        public byte[] CrCardNoEnc { get; set; } // CR_CARD_NO_ENC (length: 32)
        public byte? CrCardNoKid { get; set; } // CR_CARD_NO_KID
        public DateTime? BatchDt { get; set; } // BATCH_DT
        public DateTime? RsUtcDt { get; set; } = DateTime.UtcNow; // RS_UTC_DT
        public byte RsStat { get; set; } = 1; // RS_STAT

        // Foreign keys

        /// <summary>
        /// Parent PsStr pointed by [SY_EDC_TRX].([StrId]) (FK_SY_EDC_TRX_PS_STR)
        /// </summary>
        public virtual PsStr PsStr { get; set; } // FK_SY_EDC_TRX_PS_STR
    }

}
// </auto-generated>
