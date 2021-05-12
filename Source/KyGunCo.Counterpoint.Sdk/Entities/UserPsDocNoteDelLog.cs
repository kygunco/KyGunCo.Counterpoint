// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // USER_PS_DOC_NOTE_DEL_LOG
    public class UserPsDocNoteDelLog
    {
        public long DocId { get; set; } // DOC_ID (Primary key)
        public string NoteId { get; set; } // NOTE_ID (Primary key) (length: 20)
        public int NoteSeqNo { get; set; } // NOTE_SEQ_NO (Primary key)
        public DateTime? NoteDat { get; set; } // NOTE_DAT
        public string UsrId { get; set; } // USR_ID (length: 10)
        public string Note { get; set; } // NOTE (length: 2147483647)
        public string NoteTxt { get; set; } // NOTE_TXT (length: 2147483647)
        public Guid? LinGuid { get; set; } // LIN_GUID
        public string DelUsrId { get; set; } // DEL_USR_ID (length: 10)
        public DateTime? DelDt { get; set; } // DEL_DT
    }

}
// </auto-generated>
