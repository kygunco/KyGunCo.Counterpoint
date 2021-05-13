// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PS_LWY_HIST_LIN_SER_EXT
    public class PsLwyHistLinSerExt
    {
        public DateTime BusDatExt { get; set; } // BUS_DAT_EXT (Primary key)
        public long DocIdExt { get; set; } // DOC_ID_EXT (Primary key)
        public int LinSeqNoExt { get; set; } // LIN_SEQ_NO_EXT (Primary key)
        public string SerNoExt { get; set; } // SER_NO_EXT (Primary key) (length: 30)

        // Foreign keys

        /// <summary>
        /// Parent PsLwyHistLinSer pointed by [PS_LWY_HIST_LIN_SER_EXT].([BusDatExt], [DocIdExt], [LinSeqNoExt], [SerNoExt]) (FK_PS_LWY_HIST_LIN_SER_EXT_PS_LWY_HIST_LIN_SER)
        /// </summary>
        public virtual PsLwyHistLinSer PsLwyHistLinSer { get; set; } // FK_PS_LWY_HIST_LIN_SER_EXT_PS_LWY_HIST_LIN_SER
    }

}
// </auto-generated>