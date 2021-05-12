// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_TKT_HIST_PKG_TRK_NO
    public class PsTktHistPkgTrkNo
    {
        public DateTime BusDat { get; set; } // BUS_DAT (Primary key)
        public long DocId { get; set; } // DOC_ID (Primary key)
        public int PkgTrkSeqNo { get; set; } // PKG_TRK_SEQ_NO (Primary key)
        public string PkgTrkNo { get; set; } // PKG_TRK_NO (length: 25)

        // Foreign keys

        /// <summary>
        /// Parent PsTktHist pointed by [PS_TKT_HIST_PKG_TRK_NO].([BusDat], [DocId]) (FK_PS_TKT_HIST_PKG_TRK_NO_PS_TKT_HIST)
        /// </summary>
        public virtual PsTktHist PsTktHist { get; set; } // FK_PS_TKT_HIST_PKG_TRK_NO_PS_TKT_HIST
    }

}
// </auto-generated>
