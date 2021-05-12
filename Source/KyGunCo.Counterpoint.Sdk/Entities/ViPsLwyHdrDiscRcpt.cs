// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_PS_LWY_HDR_DISC_RCPT
    public class ViPsLwyHdrDiscRcpt
    {
        public DateTime BusDat { get; set; } // BUS_DAT
        public long DocId { get; set; } // DOC_ID
        public int DiscSeqNo { get; set; } // DISC_SEQ_NO
        public long DiscId { get; set; } // DISC_ID
        public string DiscCod { get; set; } // DISC_COD (length: 10)
        public string DiscDescr { get; set; } // DISC_DESCR (length: 30)
        public string ApplyTo { get; set; } // APPLY_TO (length: 1)
        public string DiscTyp { get; set; } // DISC_TYP (length: 1)
        public decimal DiscAmt { get; set; } // DISC_AMT
        public decimal DiscPct { get; set; } // DISC_PCT
        public decimal DiscAmtShipped { get; set; } // DISC_AMT_SHIPPED
        public decimal? MinDiscntblAmt { get; set; } // MIN_DISCNTBL_AMT
    }

}
// </auto-generated>
