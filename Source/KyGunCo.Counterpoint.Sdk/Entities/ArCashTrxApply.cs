// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // AR_CASH_TRX_APPLY
    public class ArCashTrxApply
    {
        public string CustNo { get; set; } // CUST_NO (Primary key) (length: 15)
        public string DocNo { get; set; } // DOC_NO (Primary key) (length: 15)
        public DateTime ApplyToDocDat { get; set; } // APPLY_TO_DOC_DAT (Primary key)
        public string ApplyToDocNo { get; set; } // APPLY_TO_DOC_NO (Primary key) (length: 15)
        public string ApplyToDocTyp { get; set; } // APPLY_TO_DOC_TYP (Primary key) (length: 1)
        public int? SeqNo { get; set; } // SEQ_NO
        public decimal Amt { get; set; } // AMT
        public decimal? DiscAmt { get; set; } // DISC_AMT
        public string DiscAcctNo { get; set; } // DISC_ACCT_NO (length: 20)
        public string DiscAcctFromTerms { get; set; } = "Y"; // DISC_ACCT_FROM_TERMS (length: 1)
        public decimal? WrtoffAmt { get; set; } = 0m; // WRTOFF_AMT
        public string WrtoffAcctNo { get; set; } // WRTOFF_ACCT_NO (length: 20)
        public string UseDfltWrtoffAcct { get; set; } = "Y"; // USE_DFLT_WRTOFF_ACCT (length: 1)
        public string LinIsOpn { get; set; } = "N"; // LIN_IS_OPN (length: 1)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS

        // Foreign keys

        /// <summary>
        /// Parent ArCashTrx pointed by [AR_CASH_TRX_APPLY].([CustNo], [DocNo]) (FK_AR_CASH_TRX_APPLY_AR_CASH_TRX)
        /// </summary>
        public virtual ArCashTrx ArCashTrx { get; set; } // FK_AR_CASH_TRX_APPLY_AR_CASH_TRX
    }

}
// </auto-generated>
