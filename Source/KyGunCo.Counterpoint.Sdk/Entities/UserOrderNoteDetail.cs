// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // USER_ORDER_NOTE_DETAILS
    public class UserOrderNoteDetail
    {
        public long DocId { get; set; } // DOC_ID
        public DateTime? BusDat { get; set; } // BUS_DAT
        public string TktNo { get; set; } // TKT_NO (length: 15)
        public string WebOrdNo { get; set; } // WEB_ORD_NO (length: 15)
        public string NoteId { get; set; } // NOTE_ID (length: 20)
        public int NoteSeqNo { get; set; } // NOTE_SEQ_NO
        public DateTime? NoteDat { get; set; } // NOTE_DAT
        public string UsrId { get; set; } // USR_ID (length: 10)
        public string NoteTxt { get; set; } // NOTE_TXT (length: 2147483647)
    }

}
// </auto-generated>
