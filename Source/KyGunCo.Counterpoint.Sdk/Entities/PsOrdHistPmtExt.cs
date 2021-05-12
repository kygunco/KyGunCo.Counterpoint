// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_ORD_HIST_PMT_EXT
    public class PsOrdHistPmtExt
    {
        public DateTime BusDatExt { get; set; } // BUS_DAT_EXT (Primary key)
        public long DocIdExt { get; set; } // DOC_ID_EXT (Primary key)
        public int PmtSeqNoExt { get; set; } // PMT_SEQ_NO_EXT (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent PsOrdHistPmt pointed by [PS_ORD_HIST_PMT_EXT].([BusDatExt], [DocIdExt], [PmtSeqNoExt]) (FK_PS_ORD_HIST_PMT_EXT_PS_ORD_HIST_PMT)
        /// </summary>
        public virtual PsOrdHistPmt PsOrdHistPmt { get; set; } // FK_PS_ORD_HIST_PMT_EXT_PS_ORD_HIST_PMT
    }

}
// </auto-generated>
