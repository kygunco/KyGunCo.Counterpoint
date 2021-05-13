// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_UNPSTD_SER_NO
    public class ViUnpstdSerNo
    {
        public string TrxType { get; set; } // TRX_TYPE (length: 1)
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public string SerNo { get; set; } // SER_NO (length: 30)
        public string LocId { get; set; } // LOC_ID (length: 10)
        public string DocNo { get; set; } // DOC_NO (length: 15)
        public DateTime TrxDat { get; set; } // TRX_DAT
        public string BatId { get; set; } // BAT_ID (length: 10)
        public string StrId { get; set; } // STR_ID (length: 1)
        public string StaId { get; set; } // STA_ID (length: 1)
    }

}
// </auto-generated>