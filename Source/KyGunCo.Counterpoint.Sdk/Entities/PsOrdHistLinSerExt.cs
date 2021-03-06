// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_ORD_HIST_LIN_SER_EXT
    public class PsOrdHistLinSerExt
    {
        public DateTime BusDatExt { get; set; } // BUS_DAT_EXT (Primary key)
        public long DocIdExt { get; set; } // DOC_ID_EXT (Primary key)
        public int LinSeqNoExt { get; set; } // LIN_SEQ_NO_EXT (Primary key)
        public string SerNoExt { get; set; } // SER_NO_EXT (Primary key) (length: 30)

        // Foreign keys

        /// <summary>
        /// Parent PsOrdHistLinSer pointed by [PS_ORD_HIST_LIN_SER_EXT].([BusDatExt], [DocIdExt], [LinSeqNoExt], [SerNoExt]) (FK_PS_ORD_HIST_LIN_SER_EXT_PS_ORD_HIST_LIN_SER)
        /// </summary>
        public virtual PsOrdHistLinSer PsOrdHistLinSer { get; set; } // FK_PS_ORD_HIST_LIN_SER_EXT_PS_ORD_HIST_LIN_SER
    }

}
// </auto-generated>
