// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_AR_LOY_PT_HIST
    public class ViArLoyPtHist
    {
        public string Type { get; set; } // TYPE (length: 1)
        public string Posted { get; set; } // POSTED (length: 1)
        public string EventNo { get; set; } // EVENT_NO (length: 15)
        public string CustNo { get; set; } // CUST_NO (length: 15)
        public string LoyPgmCod { get; set; } // LOY_PGM_COD (length: 10)
        public int? NoOfPts { get; set; } // NO_OF_PTS
        public DateTime? TrxDat { get; set; } // TRX_DAT
        public string DocNo { get; set; } // DOC_NO (length: 15)
        public string Commnt { get; set; } // COMMNT (length: 50)
        public string BatId { get; set; } // BAT_ID (length: 10)
        public Guid? DocRowTs { get; set; } // DOC_ROW_TS
        public string StrId { get; set; } // STR_ID (length: 10)
        public string StaId { get; set; } // STA_ID (length: 10)
        public int? SeqNo { get; set; } // SEQ_NO
        public DateTime? BusDat { get; set; } // BUS_DAT
        public long? DocId { get; set; } // DOC_ID
    }

}
// </auto-generated>