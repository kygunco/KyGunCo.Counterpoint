// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // DM_AGG_LOG
    public class DmAggLog
    {
        public int AggExecId { get; set; } // AGG_EXEC_ID (Primary key)
        public string AggStatus { get; set; } // AGG_STATUS (length: 1)
        public DateTime AggStartDt { get; set; } // AGG_START_DT
        public DateTime? AggEndDt { get; set; } // AGG_END_DT
        public byte[] RowTs { get; set; } // ROW_TS

        // Reverse navigation

        /// <summary>
        /// Child DmAggDetailLogs where [DM_AGG_DETAIL_LOG].[AGG_EXEC_ID] point to this entity (FK_DM_AGG_DETAIL_LOG_DM_AGG_LOG)
        /// </summary>
        public virtual IList<DmAggDetailLog> DmAggDetailLogs { get; set; } = new List<DmAggDetailLog>(); // DM_AGG_DETAIL_LOG.FK_DM_AGG_DETAIL_LOG_DM_AGG_LOG

        /// <summary>
        /// Child DmAggStatsLogs where [DM_AGG_STATS_LOG].[AGG_EXEC_ID] point to this entity (FK_DM_AGG_STATS_LOG_DM_AGG_LOG)
        /// </summary>
        public virtual IList<DmAggStatsLog> DmAggStatsLogs { get; set; } = new List<DmAggStatsLog>(); // DM_AGG_STATS_LOG.FK_DM_AGG_STATS_LOG_DM_AGG_LOG
    }

}
// </auto-generated>
