// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // AR_CASH_TRX
    public class ArCashTrx
    {
        public string CustNo { get; set; } // CUST_NO (Primary key) (length: 15)
        public string DocNo { get; set; } // DOC_NO (Primary key) (length: 15)
        public string BatId { get; set; } // BAT_ID (length: 10)
        public int? EntrySeqNo { get; set; } = 0; // ENTRY_SEQ_NO
        public string PayCod { get; set; } // PAY_COD (length: 10)
        public DateTime TrxDat { get; set; } = DateTime.Now; // TRX_DAT
        public decimal Amt { get; set; } // AMT
        public decimal? DiscTaken { get; set; } // DISC_TAKEN
        public decimal? TotWrtoffAmt { get; set; } = 0m; // TOT_WRTOFF_AMT
        public string StrId { get; set; } // STR_ID (length: 10)
        public string Ref { get; set; } // REF (length: 50)
        public string ErrRef { get; set; } // ERR_REF (length: 255)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string RvrslOfEventNo { get; set; } // RVRSL_OF_EVENT_NO (length: 15)
        public string RvrslOfDocNo { get; set; } // RVRSL_OF_DOC_NO (length: 15)

        // Reverse navigation

        /// <summary>
        /// Child ArCashTrxApplies where [AR_CASH_TRX_APPLY].([CUST_NO], [DOC_NO]) point to this entity (FK_AR_CASH_TRX_APPLY_AR_CASH_TRX)
        /// </summary>
        public virtual IList<ArCashTrxApply> ArCashTrxApplies { get; set; } = new List<ArCashTrxApply>(); // AR_CASH_TRX_APPLY.FK_AR_CASH_TRX_APPLY_AR_CASH_TRX

        // Foreign keys

        /// <summary>
        /// Parent ArCust pointed by [AR_CASH_TRX].([CustNo]) (FK_AR_CASH_TRX_AR_CUST)
        /// </summary>
        public virtual ArCust ArCust { get; set; } // FK_AR_CASH_TRX_AR_CUST
    }

}
// </auto-generated>