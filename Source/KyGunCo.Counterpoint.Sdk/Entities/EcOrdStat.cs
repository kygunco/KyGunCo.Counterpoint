// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // EC_ORD_STAT
    public class EcOrdStat
    {
        public string EcOrdNo { get; set; } // EC_ORD_NO (Primary key) (length: 9)
        public string OrdAccepted { get; set; } = "N"; // ORD_ACCEPTED (length: 1)
        public string OrdChanged { get; set; } = "N"; // ORD_CHANGED (length: 1)
        public string OrdReleased { get; set; } = "N"; // ORD_RELEASED (length: 1)
        public string OrdCancelled { get; set; } = "N"; // ORD_CANCELLED (length: 1)
        public string OrdCrCardDenied { get; set; } = "N"; // ORD_CR_CARD_DENIED (length: 1)
        public string OrdOnBo { get; set; } = "N"; // ORD_ON_BO (length: 1)
        public string Selectd { get; set; } = "N"; // SELECTD (length: 1)
        public string OldOrdChanged { get; set; } = "N"; // OLD_ORD_CHANGED (length: 1)
        public string OldOrdCrCardDenied { get; set; } = "N"; // OLD_ORD_CR_CARD_DENIED (length: 1)
        public string OldOrdOnBo { get; set; } = "N"; // OLD_ORD_ON_BO (length: 1)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS

        // Reverse navigation

        /// <summary>
        /// Child EcOrdStatRelTkts where [EC_ORD_STAT_REL_TKTS].[EC_ORD_NO] point to this entity (FK_EC_ORD_STAT_REL_TKTS_EC_ORD_STAT)
        /// </summary>
        public virtual IList<EcOrdStatRelTkt> EcOrdStatRelTkts { get; set; } = new List<EcOrdStatRelTkt>(); // EC_ORD_STAT_REL_TKTS.FK_EC_ORD_STAT_REL_TKTS_EC_ORD_STAT
    }

}
// </auto-generated>
