// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_DRW_SESSION_EVENT
    public class PsDrwSessionEvent
    {
        public string StrId { get; set; } // STR_ID (Primary key) (length: 10)
        public string DrwId { get; set; } // DRW_ID (Primary key) (length: 10)
        public long DrwSessionId { get; set; } // DRW_SESSION_ID (Primary key)
        public int EventId { get; set; } // EVENT_ID (Primary key)
        public DateTime EventDt { get; set; } // EVENT_DT
        public string EventTyp { get; set; } // EVENT_TYP (length: 1)
        public string EventStat { get; set; } = "!"; // EVENT_STAT (length: 1)
        public string Ref { get; set; } // REF (length: 250)
        public string StaId { get; set; } // STA_ID (length: 10)
        public string UsrId { get; set; } // USR_ID (length: 10)
        public bool IsAutoEvent { get; set; } = false; // IS_AUTO_EVENT
        public decimal Amt { get; set; } // AMT
        public decimal OverShortAmt { get; set; } // OVER_SHORT_AMT
        public bool IsOffline { get; set; } = false; // IS_OFFLINE
        public bool? ReconForced { get; set; } // RECON_FORCED

        // Reverse navigation

        /// <summary>
        /// Child PsDrwSessionEventDetails where [PS_DRW_SESSION_EVENT_DETAIL].([DRW_ID], [DRW_SESSION_ID], [EVENT_ID], [STR_ID]) point to this entity (FK_PS_DRW_SESSION_EVENT_DETAIL_PS_DRW_SESSION_EVENT)
        /// </summary>
        public virtual IList<PsDrwSessionEventDetail> PsDrwSessionEventDetails { get; set; } = new List<PsDrwSessionEventDetail>(); // PS_DRW_SESSION_EVENT_DETAIL.FK_PS_DRW_SESSION_EVENT_DETAIL_PS_DRW_SESSION_EVENT

        // Foreign keys

        /// <summary>
        /// Parent PsDrwSession pointed by [PS_DRW_SESSION_EVENT].([StrId], [DrwId], [DrwSessionId]) (FK_PS_DRW_SESSION_EVENT_PS_DRW_SESSION)
        /// </summary>
        public virtual PsDrwSession PsDrwSession { get; set; } // FK_PS_DRW_SESSION_EVENT_PS_DRW_SESSION

        /// <summary>
        /// Parent SyUsr pointed by [PS_DRW_SESSION_EVENT].([UsrId]) (FK_PS_DRW_SESSION_EVENT_SY_USR)
        /// </summary>
        public virtual SyUsr SyUsr { get; set; } // FK_PS_DRW_SESSION_EVENT_SY_USR
    }

}
// </auto-generated>