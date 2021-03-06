// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // RS_CTL
    public class RsCtl
    {
        public int KeyId { get; set; } = 1; // KEY_ID (Primary key)
        public string StrId { get; set; } // STR_ID (length: 10)
        public string StaId { get; set; } // STA_ID (length: 10)
        public bool IsSiteServer { get; set; } // IS_SITE_SERVER
        public string ParentServNam { get; set; } // PARENT_SERV_NAM (length: 128)
        public int ExtractionFreqSecs { get; set; } = 900; // EXTRACTION_FREQ_SECS
        public string ExtractionEnabled { get; set; } = "Y"; // EXTRACTION_ENABLED (length: 1)
        public DateTime? LastExtractionDt { get; set; } // LAST_EXTRACTION_DT
    }

}
// </auto-generated>
