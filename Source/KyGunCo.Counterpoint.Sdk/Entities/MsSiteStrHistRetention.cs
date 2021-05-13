// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // MS_SITE_STR_HIST_RETENTION
    public class MsSiteStrHistRetention
    {
        public int SiteId { get; set; } // SITE_ID (Primary key)
        public string StrId { get; set; } // STR_ID (Primary key) (length: 10)
        public string DataType { get; set; } // DATA_TYPE (length: 1)
        public string TimePrdCod { get; set; } // TIME_PRD_COD (length: 1)
        public int RetainTimePrds { get; set; } = 0; // RETAIN_TIME_PRDS
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
    }

}
// </auto-generated>