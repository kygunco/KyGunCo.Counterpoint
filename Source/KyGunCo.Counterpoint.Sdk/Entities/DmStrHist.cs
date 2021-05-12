// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // DM_STR_HIST
    public class DmStrHist
    {
        public string StrId { get; set; } // STR_ID (Primary key) (length: 10)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS

        // Reverse navigation

        /// <summary>
        /// Child DmMbItemStrDays where [DM_MB_ITEM_STR_DAY].[STR_ID] point to this entity (FK_DM_MB_ITEM_STR_DAY_DM_STR_HIST)
        /// </summary>
        public virtual IList<DmMbItemStrDay> DmMbItemStrDays { get; set; } = new List<DmMbItemStrDay>(); // DM_MB_ITEM_STR_DAY.FK_DM_MB_ITEM_STR_DAY_DM_STR_HIST

        /// <summary>
        /// Child DmMbItemStrMnths where [DM_MB_ITEM_STR_MNTH].[STR_ID] point to this entity (FK_DM_MB_ITEM_STR_MNTH_DM_STR_HIST)
        /// </summary>
        public virtual IList<DmMbItemStrMnth> DmMbItemStrMnths { get; set; } = new List<DmMbItemStrMnth>(); // DM_MB_ITEM_STR_MNTH.FK_DM_MB_ITEM_STR_MNTH_DM_STR_HIST

        /// <summary>
        /// Child DmSalStrItemDays where [DM_SAL_STR_ITEM_DAY].[STR_ID] point to this entity (FK_DM_SAL_STR_ITEM_DAY_DM_STR_HIST)
        /// </summary>
        public virtual IList<DmSalStrItemDay> DmSalStrItemDays { get; set; } = new List<DmSalStrItemDay>(); // DM_SAL_STR_ITEM_DAY.FK_DM_SAL_STR_ITEM_DAY_DM_STR_HIST

        /// <summary>
        /// Child DmSalStrItemMnths where [DM_SAL_STR_ITEM_MNTH].[STR_ID] point to this entity (FK_DM_SAL_STR_ITEM_MNTH_DM_STR_HIST)
        /// </summary>
        public virtual IList<DmSalStrItemMnth> DmSalStrItemMnths { get; set; } = new List<DmSalStrItemMnth>(); // DM_SAL_STR_ITEM_MNTH.FK_DM_SAL_STR_ITEM_MNTH_DM_STR_HIST

        /// <summary>
        /// Child DmStatsStrUsrDays where [DM_STATS_STR_USR_DAY].[STR_ID] point to this entity (FK_DM_STATS_STR_USR_DAY_DM_STR_HIST)
        /// </summary>
        public virtual IList<DmStatsStrUsrDay> DmStatsStrUsrDays { get; set; } = new List<DmStatsStrUsrDay>(); // DM_STATS_STR_USR_DAY.FK_DM_STATS_STR_USR_DAY_DM_STR_HIST

        /// <summary>
        /// Child DmTargetStrMnths where [DM_TARGET_STR_MNTH].[STR_ID] point to this entity (FK_DM_TARGET_STR_MNTH_DM_STR_HIST)
        /// </summary>
        public virtual IList<DmTargetStrMnth> DmTargetStrMnths { get; set; } = new List<DmTargetStrMnth>(); // DM_TARGET_STR_MNTH.FK_DM_TARGET_STR_MNTH_DM_STR_HIST

        /// <summary>
        /// Child DmTotStrDays where [DM_TOT_STR_DAY].[STR_ID] point to this entity (FK_DM_TOT_STR_DAY_DM_STR_HIST)
        /// </summary>
        public virtual IList<DmTotStrDay> DmTotStrDays { get; set; } = new List<DmTotStrDay>(); // DM_TOT_STR_DAY.FK_DM_TOT_STR_DAY_DM_STR_HIST

        /// <summary>
        /// Child DmTotStrHrs where [DM_TOT_STR_HR].[STR_ID] point to this entity (FK_DM_TOT_STR_HR_DM_STR_HIST)
        /// </summary>
        public virtual IList<DmTotStrHr> DmTotStrHrs { get; set; } = new List<DmTotStrHr>(); // DM_TOT_STR_HR.FK_DM_TOT_STR_HR_DM_STR_HIST

        /// <summary>
        /// Child DmTotStrMnths where [DM_TOT_STR_MNTH].[STR_ID] point to this entity (FK_DM_TOT_STR_MNTH_DM_STR_HIST)
        /// </summary>
        public virtual IList<DmTotStrMnth> DmTotStrMnths { get; set; } = new List<DmTotStrMnth>(); // DM_TOT_STR_MNTH.FK_DM_TOT_STR_MNTH_DM_STR_HIST

        /// <summary>
        /// Child DmTrxLogDays where [DM_TRX_LOG_DAY].[STR_ID] point to this entity (FK_DM_TRX_LOG_DAY_DM_STR_HIST)
        /// </summary>
        public virtual IList<DmTrxLogDay> DmTrxLogDays { get; set; } = new List<DmTrxLogDay>(); // DM_TRX_LOG_DAY.FK_DM_TRX_LOG_DAY_DM_STR_HIST
    }

}
// </auto-generated>
