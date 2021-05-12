// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PO_PREQ_NOTE
    public class PoPreqNote
    {
        public string PreqNo { get; set; } // PREQ_NO (Primary key) (length: 15)
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
        /// Parent PoPreqHdr pointed by [PO_PREQ_NOTE].([PreqNo]) (FK_PO_PREQ_NOTE_PO_PREQ_HDR)
        /// </summary>
        public virtual PoPreqHdr PoPreqHdr { get; set; } // FK_PO_PREQ_NOTE_PO_PREQ_HDR
    }

}
// </auto-generated>
