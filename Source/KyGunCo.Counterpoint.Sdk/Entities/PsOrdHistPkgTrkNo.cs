// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_ORD_HIST_PKG_TRK_NO
    public class PsOrdHistPkgTrkNo
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public int PkgTrkSeqNo { get; set; } // PKG_TRK_SEQ_NO (Primary key)
        public string PkgTrkNo { get; set; } // PKG_TRK_NO (length: 25)

        // Foreign keys

        /// <summary>
        /// Parent PsOrdHist pointed by [PS_ORD_HIST_PKG_TRK_NO].([BusDat], [DocId]) (FK_PS_ORD_HIST_PKG_TRK_NO_PS_ORD_HIST)
        /// </summary>
        public virtual PsOrdHist PsOrdHist { get; set; } // FK_PS_ORD_HIST_PKG_TRK_NO_PS_ORD_HIST
    }

}
// </auto-generated>
