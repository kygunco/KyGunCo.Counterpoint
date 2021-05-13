// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // DM_LOC_HIST
    public class DmLocHist
    {
        public string LocId { get; set; } // LOC_ID (Primary key) (length: 10)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS

        // Reverse navigation

        /// <summary>
        /// Child DmForcstMnthCaches where [DM_FORCST_MNTH_CACHE].[LOC_ID] point to this entity (FK_DM_FORCST_MNTH_CACHE_DM_LOC_HIST)
        /// </summary>
        public virtual IList<DmForcstMnthCache> DmForcstMnthCaches { get; set; } = new List<DmForcstMnthCache>(); // DM_FORCST_MNTH_CACHE.FK_DM_FORCST_MNTH_CACHE_DM_LOC_HIST

        /// <summary>
        /// Child DmInvLocItemAdjs where [DM_INV_LOC_ITEM_ADJ].[LOC_ID] point to this entity (FK_DM_INV_LOC_ITEM_ADJ_DM_LOC_HIST)
        /// </summary>
        public virtual IList<DmInvLocItemAdj> DmInvLocItemAdjs { get; set; } = new List<DmInvLocItemAdj>(); // DM_INV_LOC_ITEM_ADJ.FK_DM_INV_LOC_ITEM_ADJ_DM_LOC_HIST

        /// <summary>
        /// Child DmInvLocItemMnths where [DM_INV_LOC_ITEM_MNTH].[LOC_ID] point to this entity (FK_DM_INV_LOC_ITEM_MNTH_DM_LOC_HIST)
        /// </summary>
        public virtual IList<DmInvLocItemMnth> DmInvLocItemMnths { get; set; } = new List<DmInvLocItemMnth>(); // DM_INV_LOC_ITEM_MNTH.FK_DM_INV_LOC_ITEM_MNTH_DM_LOC_HIST

        /// <summary>
        /// Child DmTrxLocItemMnths where [DM_TRX_LOC_ITEM_MNTH].[LOC_ID] point to this entity (FK_DM_TRX_LOC_ITEM_MNTH_DM_LOC_HIST)
        /// </summary>
        public virtual IList<DmTrxLocItemMnth> DmTrxLocItemMnths { get; set; } = new List<DmTrxLocItemMnth>(); // DM_TRX_LOC_ITEM_MNTH.FK_DM_TRX_LOC_ITEM_MNTH_DM_LOC_HIST
    }

}
// </auto-generated>