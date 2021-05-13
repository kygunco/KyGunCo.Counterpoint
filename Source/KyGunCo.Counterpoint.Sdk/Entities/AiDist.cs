// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // AI_DIST
    public class AiDist
    {
        public string BatId { get; set; } // BAT_ID (Primary key) (length: 10)
        public int SeqNo { get; set; } // SEQ_NO (Primary key)
        public string DistGrp { get; set; } // DIST_GRP (length: 1)
        public string DistTyp { get; set; } // DIST_TYP (length: 1)
        public string AcctNo { get; set; } // ACCT_NO (length: 50)
        public DateTime? DistDat { get; set; } // DIST_DAT
        public string EventNo { get; set; } // EVENT_NO (length: 15)
        public string PkgId { get; set; } // PKG_ID (length: 2)
        public string ActTyp { get; set; } // ACT_TYP (length: 3)
        public decimal? Amt { get; set; } // AMT
        public string FstDocNo { get; set; } // FST_DOC_NO (length: 15)
        public string FstRef { get; set; } // FST_REF (length: 50)
        public string CpAcctNo { get; set; } // CP_ACCT_NO (length: 20)
    }

}
// </auto-generated>