// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_DRW_SESSION_HIST_CHKSUM
    public class PsDrwSessionHistChksum
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public string StrId { get; set; } // STR_ID (Primary key) (length: 10)
        public string DrwId { get; set; } // DRW_ID (Primary key) (length: 10)
        public long DrwSessionId { get; set; } // DRW_SESSION_ID (Primary key)
        public string StaId { get; set; } // STA_ID (Primary key) (length: 10)
        public bool ChksumMatch { get; set; } // CHKSUM_MATCH
        public decimal TotDocAmt { get; set; } // TOT_DOC_AMT
        public int DocCnt { get; set; } // DOC_CNT
        public int DocLinCnt { get; set; } // DOC_LIN_CNT
    }

}
// </auto-generated>