// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_VOID_HIST_PMT_RCPT
    public class PsVoidHistPmtRcpt
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public int PmtSeqNo { get; set; } // PMT_SEQ_NO (Primary key)
        public string TransTyp { get; set; } = "0"; // TRANS_TYP (length: 2)
        public string UniqueTransId { get; set; } // UNIQUE_TRANS_ID (length: 20)
        public string TransStat { get; set; } = "0"; // TRANS_STAT (length: 2)
        public string RcptAuthCod { get; set; } // RCPT_AUTH_COD (length: 10)
        public string TransApproved { get; set; } = "N"; // TRANS_APPROVED (length: 1)
        public string ProcessorTransId { get; set; } // PROCESSOR_TRANS_ID (length: 20)
        public string RcptCardNoMsk { get; set; } // RCPT_CARD_NO_MSK (length: 30)
        public string RcptAcctTyp { get; set; } = "0"; // RCPT_ACCT_TYP (length: 2)
        public string RcptCardTyp { get; set; } = "0"; // RCPT_CARD_TYP (length: 2)
        public DateTime? RcptTransDat { get; set; } // RCPT_TRANS_DAT
        public DateTime? RcptTransTim { get; set; } // RCPT_TRANS_TIM
        public string ProcessorRefNo { get; set; } // PROCESSOR_REF_NO (length: 20)
        public decimal? RcptAmt { get; set; } // RCPT_AMT
        public string RcptLang { get; set; } = "0"; // RCPT_LANG (length: 2)
        public string ProcessorMsg { get; set; } // PROCESSOR_MSG (length: 250)
        public string ErrorMsg { get; set; } // ERROR_MSG (length: 250)
        public string RcptStrId { get; set; } // RCPT_STR_ID (length: 30)
        public string RcptTermId { get; set; } // RCPT_TERM_ID (length: 30)
        public string RcptMsg { get; set; } // RCPT_MSG (length: 250)
        public string EntryMeth { get; set; } = "0"; // ENTRY_METH (length: 2)
        public string AvsResult { get; set; } // AVS_RESULT (length: 1)
        public string CvvResult { get; set; } // CVV_RESULT (length: 1)
        public decimal? CardBalRemain { get; set; } // CARD_BAL_REMAIN
        public string ProcessorClientRcpt { get; set; } // PROCESSOR_CLIENT_RCPT (length: 7000)
        public string ProcessorMerchRcpt { get; set; } // PROCESSOR_MERCH_RCPT (length: 7000)
        public string ProcessorRcpt { get; set; } // PROCESSOR_RCPT (length: 7000)
        public string OfflineAuthCod { get; set; } // OFFLINE_AUTH_COD (length: 10)
        public string OfflineTransStatus { get; set; } // OFFLINE_TRANS_STATUS (length: 1)
        public DateTime? OfflineLstMaintDt { get; set; } // OFFLINE_LST_MAINT_DT
        public string CardPlan { get; set; } // CARD_PLAN (length: 25)
        public string AppId { get; set; } // APP_ID (length: 40)
        public string AppLbl { get; set; } // APP_LBL (length: 20)
        public string AppPrefNam { get; set; } // APP_PREF_NAM (length: 20)
        public string Arqc { get; set; } // ARQC (length: 20)
        public string Tvrarqc { get; set; } // TVRARQC (length: 20)
        public string Tcacc { get; set; } // TCACC (length: 20)
        public string Tvrtcacc { get; set; } // TVRTCACC (length: 20)
        public string CardholderVerifyMeth { get; set; } // CARDHOLDER_VERIFY_METH (length: 2)
        public string ResponseCod { get; set; } // RESPONSE_COD (length: 3)
        public string Tsi { get; set; } // TSI (length: 20)

        // Foreign keys

        /// <summary>
        /// Parent PsVoidHistPmt pointed by [PS_VOID_HIST_PMT_RCPT].([BusDat], [DocId], [PmtSeqNo]) (FK_PS_VOID_HIST_PMT_RCPT_PS_VOID_HIST_PMT)
        /// </summary>
        public virtual PsVoidHistPmt PsVoidHistPmt { get; set; } // FK_PS_VOID_HIST_PMT_RCPT_PS_VOID_HIST_PMT
    }

}
// </auto-generated>
