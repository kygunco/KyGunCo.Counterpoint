// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_AR_UNPSTD_DOC
    public class ViArUnpstdDoc
    {
        public string Type { get; set; } // TYPE (length: 5)
        public string CustNo { get; set; } // CUST_NO (length: 15)
        public DateTime? DocDat { get; set; } // DOC_DAT
        public string DocNo { get; set; } // DOC_NO (length: 15)
        public string DocTyp { get; set; } // DOC_TYP (length: 1)
        public decimal? Amt { get; set; } // AMT
        public string BatId { get; set; } // BAT_ID (length: 10)
        public string ApplyToMeth { get; set; } // APPLY_TO_METH (length: 1)
        public DateTime? ApplyToDocDat { get; set; } // APPLY_TO_DOC_DAT
        public string ApplyToDocNo { get; set; } // APPLY_TO_DOC_NO (length: 15)
        public string ApplyToDocTyp { get; set; } // APPLY_TO_DOC_TYP (length: 1)
        public string StrId { get; set; } // STR_ID (length: 10)
        public string AcctNo { get; set; } // ACCT_NO (length: 20)
        public string TermsCod { get; set; } // TERMS_COD (length: 10)
        public DateTime? DueDat { get; set; } // DUE_DAT
        public DateTime? DiscDat { get; set; } // DISC_DAT
        public decimal? DiscPct { get; set; } // DISC_PCT
        public string SlsRep { get; set; } // SLS_REP (length: 10)
        public string PayCod { get; set; } // PAY_COD (length: 10)
        public string TktNo { get; set; } // TKT_NO (length: 15)
        public string StaId { get; set; } // STA_ID (length: 10)
    }

}
// </auto-generated>