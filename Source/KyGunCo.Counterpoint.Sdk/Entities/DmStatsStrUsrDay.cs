// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // DM_STATS_STR_USR_DAY
    public class DmStatsStrUsrDay
    {
        public string StrId { get; set; } // STR_ID (Primary key) (length: 10)
        public string UsrId { get; set; } // USR_ID (Primary key) (length: 10)
        public DateTime Dat { get; set; } // DAT (Primary key)
        public int TktCnt { get; set; } // TKT_CNT
        public decimal TktAmt { get; set; } // TKT_AMT
        public int LinCnt { get; set; } // LIN_CNT
        public decimal OvrShrt { get; set; } // OVR_SHRT
        public decimal HoursWrkd { get; set; } // HOURS_WRKD
        public byte[] RowTs { get; set; } // ROW_TS

        // Foreign keys

        /// <summary>
        /// Parent DmStrHist pointed by [DM_STATS_STR_USR_DAY].([StrId]) (FK_DM_STATS_STR_USR_DAY_DM_STR_HIST)
        /// </summary>
        public virtual DmStrHist DmStrHist { get; set; } // FK_DM_STATS_STR_USR_DAY_DM_STR_HIST
    }

}
// </auto-generated>
