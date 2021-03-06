// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_APPLY_TO_GRPS
    public class ViApplyToGrp
    {
        public string CustNo { get; set; } // CUST_NO (length: 15)
        public DateTime DocDat { get; set; } // DOC_DAT
        public string DocNo { get; set; } // DOC_NO (length: 15)
        public string DocTyp { get; set; } // DOC_TYP (length: 1)
        public string TermsCod { get; set; } // TERMS_COD (length: 10)
        public DateTime DueDat { get; set; } // DUE_DAT
        public DateTime DiscDat { get; set; } // DISC_DAT
        public decimal? DiscPct { get; set; } // DISC_PCT
        public string SlsRep { get; set; } // SLS_REP (length: 10)
        public string Ref { get; set; } // REF (length: 50)
        public string StrId { get; set; } // STR_ID (length: 10)
        public string CustPoNo { get; set; } // CUST_PO_NO (length: 20)
        public string ApplIsOpen { get; set; } // APPL_IS_OPEN (length: 1)
        public decimal? OrigAmt { get; set; } // ORIG_AMT
        public decimal? OrigEntdAmt { get; set; } // ORIG_ENTD_AMT
        public decimal? TotDiscntblAmt { get; set; } // TOT_DISCNTBL_AMT
        public decimal? TotDiscUsed { get; set; } // TOT_DISC_USED
        public decimal? TotWrtoffAmt { get; set; } // TOT_WRTOFF_AMT
        public decimal? DocBal { get; set; } // DOC_BAL
        public decimal? OrigDiscAvail { get; set; } // ORIG_DISC_AVAIL
        public decimal? DiscAvail { get; set; } // DISC_AVAIL
        public int? NoOfAppls { get; set; } // NO_OF_APPLS
    }

}
// </auto-generated>
