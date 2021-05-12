// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_DRW_SESSION
    public class PsDrwSession
    {
        public string StrId { get; set; } // STR_ID (Primary key) (length: 10)
        public string DrwId { get; set; } // DRW_ID (Primary key) (length: 10)
        public long DrwSessionId { get; set; } // DRW_SESSION_ID (Primary key)
        public string Stat { get; set; } = "A"; // STAT (length: 1)
        public bool IsOffline { get; set; } = false; // IS_OFFLINE
        public DateTime OpenDt { get; set; } // OPEN_DT
        public DateTime? CloseDt { get; set; } // CLOSE_DT
        public string UsrId { get; set; } // USR_ID (length: 10)
        public DateTime? RsUtcDt { get; set; } = DateTime.UtcNow; // RS_UTC_DT
        public string SessionNam { get; set; } // SESSION_NAM (length: 30)
        public long? OrigDrwSessionId { get; set; } // ORIG_DRW_SESSION_ID
        public byte RsStat { get; set; } = 1; // RS_STAT
        public bool ActivdOnline { get; set; } = false; // ACTIVD_ONLINE
        public string AssgndSta { get; set; } // ASSGND_STA (length: 10)
        public string AssgndUsr { get; set; } // ASSGND_USR (length: 10)
        public long? DrwDevInstId { get; set; } // DRW_DEV_INST_ID
        public long? WorkstationId { get; set; } // WORKSTATION_ID
        public string DrwDevId { get; set; } // DRW_DEV_ID (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child PsDrwSessionEvents where [PS_DRW_SESSION_EVENT].([DRW_ID], [DRW_SESSION_ID], [STR_ID]) point to this entity (FK_PS_DRW_SESSION_EVENT_PS_DRW_SESSION)
        /// </summary>
        public virtual IList<PsDrwSessionEvent> PsDrwSessionEvents { get; set; } = new List<PsDrwSessionEvent>(); // PS_DRW_SESSION_EVENT.FK_PS_DRW_SESSION_EVENT_PS_DRW_SESSION

        // Foreign keys

        /// <summary>
        /// Parent PsDrw pointed by [PS_DRW_SESSION].([StrId], [DrwId]) (FK_PS_DRW_SESSION_PS_DRW)
        /// </summary>
        public virtual PsDrw PsDrw { get; set; } // FK_PS_DRW_SESSION_PS_DRW

        /// <summary>
        /// Parent SyUsr pointed by [PS_DRW_SESSION].([UsrId]) (FK_PS_DRW_SESSION_SY_USR)
        /// </summary>
        public virtual SyUsr SyUsr { get; set; } // FK_PS_DRW_SESSION_SY_USR
    }

}
// </auto-generated>
