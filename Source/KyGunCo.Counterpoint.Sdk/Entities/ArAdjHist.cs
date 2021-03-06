// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // AR_ADJ_HIST
    public class ArAdjHist
    {
        public string EventNo { get; set; } // EVENT_NO (Primary key) (length: 15)
        public string CustNo { get; set; } // CUST_NO (Primary key) (length: 15)
        public DateTime DocDat { get; set; } // DOC_DAT (Primary key)
        public string DocNo { get; set; } // DOC_NO (Primary key) (length: 15)
        public string DocTyp { get; set; } = "C"; // DOC_TYP (Primary key) (length: 1)
        public string BatId { get; set; } // BAT_ID (length: 10)
        public int? EntrySeqNo { get; set; } = 0; // ENTRY_SEQ_NO
        public string ApplyToMeth { get; set; } = "O"; // APPLY_TO_METH (length: 1)
        public DateTime? ApplyToDocDat { get; set; } // APPLY_TO_DOC_DAT
        public string ApplyToDocNo { get; set; } // APPLY_TO_DOC_NO (length: 15)
        public string ApplyToDocTyp { get; set; } // APPLY_TO_DOC_TYP (length: 1)
        public decimal? Amt { get; set; } // AMT
        public decimal EntdAmt { get; set; } // ENTD_AMT
        public string StrId { get; set; } // STR_ID (length: 10)
        public string Ref { get; set; } // REF (length: 50)
        public string AcctNo { get; set; } // ACCT_NO (length: 20)
        public string TermsCod { get; set; } // TERMS_COD (length: 10)
        public DateTime DueDat { get; set; } // DUE_DAT
        public DateTime DiscDat { get; set; } // DISC_DAT
        public decimal? DiscPct { get; set; } // DISC_PCT
        public string SlsRep { get; set; } // SLS_REP (length: 10)
        public decimal? CustBalBefore { get; set; } // CUST_BAL_BEFORE
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string CustStrId { get; set; } // CUST_STR_ID (length: 10)

        // Foreign keys

        /// <summary>
        /// Parent PsStrHist pointed by [AR_ADJ_HIST].([CustStrId]) (FK_AR_ADJ_HIST_PS_STR_HIST)
        /// </summary>
        public virtual PsStrHist PsStrHist { get; set; } // FK_AR_ADJ_HIST_PS_STR_HIST
    }

}
// </auto-generated>
