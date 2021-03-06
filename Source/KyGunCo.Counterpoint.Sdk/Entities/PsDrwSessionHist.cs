// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_DRW_SESSION_HIST
    public class PsDrwSessionHist
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public string StrId { get; set; } // STR_ID (Primary key) (length: 10)
        public string DrwId { get; set; } // DRW_ID (Primary key) (length: 10)
        public long DrwSessionId { get; set; } // DRW_SESSION_ID (Primary key)
        public string SessionNam { get; set; } // SESSION_NAM (length: 30)
        public string EventNo { get; set; } // EVENT_NO (length: 15)
        public string Stat { get; set; } = "A"; // STAT (length: 1)
        public bool IsOffline { get; set; } = false; // IS_OFFLINE
        public DateTime OpenDt { get; set; } // OPEN_DT
        public DateTime? CloseDt { get; set; } // CLOSE_DT
        public string UsrId { get; set; } // USR_ID (length: 10)
        public long? OrigDrwSessionId { get; set; } // ORIG_DRW_SESSION_ID

        // Reverse navigation

        /// <summary>
        /// Child PsDrwSessionHistEvents where [PS_DRW_SESSION_HIST_EVENT].([BUS_DAT], [DRW_ID], [DRW_SESSION_ID], [STR_ID]) point to this entity (FK_PS_DRW_SESSION_HIST_EVENT_PS_DRW_SESSION_HIST)
        /// </summary>
        public virtual IList<PsDrwSessionHistEvent> PsDrwSessionHistEvents { get; set; } = new List<PsDrwSessionHistEvent>(); // PS_DRW_SESSION_HIST_EVENT.FK_PS_DRW_SESSION_HIST_EVENT_PS_DRW_SESSION_HIST
    }

}
// </auto-generated>
