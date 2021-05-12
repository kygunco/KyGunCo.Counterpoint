// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // SY_EVENT_NOTE
    public class SyEventNote
    {
        public string EventNo { get; set; } // EVENT_NO (Primary key) (length: 15)
        public string NoteId { get; set; } // NOTE_ID (Primary key) (length: 20)
        public DateTime? NoteDat { get; set; } // NOTE_DAT
        public string UsrId { get; set; } // USR_ID (length: 10)
        public string Note { get; set; } // NOTE (length: 2147483647)
        public string NoteTxt { get; set; } // NOTE_TXT (length: 2147483647)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS

        // Foreign keys

        /// <summary>
        /// Parent SyEvent pointed by [SY_EVENT_NOTE].([EventNo]) (FK_SY_EVENT_NOTE_SY_EVENT)
        /// </summary>
        public virtual SyEvent SyEvent { get; set; } // FK_SY_EVENT_NOTE_SY_EVENT
    }

}
// </auto-generated>
