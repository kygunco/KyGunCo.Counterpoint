// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_TKT_HIST_PAY_COD
    public class ViTktHistPayCod
    {
        public string StrId { get; set; } // STR_ID (length: 10)
        public string PayCod { get; set; } // PAY_COD (length: 10)
        public DateTime PostDat { get; set; } // POST_DAT
        public string Descr { get; set; } // DESCR (length: 30)
        public int? TktCount { get; set; } // TKT_COUNT
        public decimal? TotTnd { get; set; } // TOT_TND
        public decimal? TotRef { get; set; } // TOT_REF
        public decimal? TotChng { get; set; } // TOT_CHNG
        public decimal? PayInAmt { get; set; } // PAY_IN_AMT
        public decimal? PayOutAmt { get; set; } // PAY_OUT_AMT
        public int? TndLins { get; set; } // TND_LINS
        public int? RefLins { get; set; } // REF_LINS
        public int? ChngLins { get; set; } // CHNG_LINS
        public int? PayInLins { get; set; } // PAY_IN_LINS
        public int? PayOutLins { get; set; } // PAY_OUT_LINS
        public decimal? ExchLoss { get; set; } // EXCH_LOSS
        public decimal? NetPmtAmt { get; set; } // NET_PMT_AMT
        public string IsForeign { get; set; } // IS_FOREIGN (length: 1)
    }

}
// </auto-generated>