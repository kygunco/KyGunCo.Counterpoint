// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_ORD_HIST_NOTE
    public class PsOrdHistNote
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public string NoteId { get; set; } // NOTE_ID (length: 20)
        public int NoteSeqNo { get; set; } // NOTE_SEQ_NO (Primary key)
        public DateTime? NoteDat { get; set; } // NOTE_DAT
        public string UsrId { get; set; } // USR_ID (length: 10)
        public string Note { get; set; } // NOTE (length: 2147483647)
        public string NoteTxt { get; set; } // NOTE_TXT (length: 2147483647)

        // Foreign keys

        /// <summary>
        /// Parent PsOrdHist pointed by [PS_ORD_HIST_NOTE].([BusDat], [DocId]) (FK_PS_ORD_HIST_NOTE_PS_ORD_HIST)
        /// </summary>
        public virtual PsOrdHist PsOrdHist { get; set; } // FK_PS_ORD_HIST_NOTE_PS_ORD_HIST
    }

}
// </auto-generated>
