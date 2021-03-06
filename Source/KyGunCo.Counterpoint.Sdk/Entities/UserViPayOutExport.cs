// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // USER_VI_PAY_OUT_EXPORT
    public class UserViPayOutExport
    {
        public DateTime BusDat { get; set; } // BUS_DAT
        public long DocId { get; set; } // DOC_ID
        public string TktNo { get; set; } // TKT_NO (length: 15)
        public DateTime? TktDt { get; set; } // TKT_DT
        public string Ref { get; set; } // REF (length: 50)
        public string DocDescr { get; set; } // DOC_DESCR (length: 30)
        public decimal? PayAmt { get; set; } // PAY_AMT
    }

}
// </auto-generated>
