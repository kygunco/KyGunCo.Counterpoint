// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // DM_METRIC
    public class DmMetric
    {
        public int MetricId { get; set; } // METRIC_ID (Primary key)
        public string Descr { get; set; } // DESCR (length: 50)
        public string FmtTmpltNam { get; set; } // FMT_TMPLT_NAM (length: 100)
        public string PresTmpltNam { get; set; } // PRES_TMPLT_NAM (length: 100)
        public decimal? LowThresholdVal { get; set; } // LOW_THRESHOLD_VAL
        public decimal? HighThresholdVal { get; set; } // HIGH_THRESHOLD_VAL
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string IsActive { get; set; } = "Y"; // IS_ACTIVE (length: 1)

        // Reverse navigation

        /// <summary>
        /// Child DmTargetStrMnths where [DM_TARGET_STR_MNTH].[METRIC_ID] point to this entity (FK_DM_TARGET_STR_MNTH_DM_METRIC)
        /// </summary>
        public virtual IList<DmTargetStrMnth> DmTargetStrMnths { get; set; } = new List<DmTargetStrMnth>(); // DM_TARGET_STR_MNTH.FK_DM_TARGET_STR_MNTH_DM_METRIC
    }

}
// </auto-generated>