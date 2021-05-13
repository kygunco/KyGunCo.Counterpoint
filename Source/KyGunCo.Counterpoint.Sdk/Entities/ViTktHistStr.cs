// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_TKT_HIST_STR
    public class ViTktHistStr
    {
        public string StrId { get; set; } // STR_ID (length: 10)
        public string Descr { get; set; } // DESCR (length: 50)
        public DateTime PostDat { get; set; } // POST_DAT
        public int? TktCount { get; set; } // TKT_COUNT
        public decimal? SalSubTot { get; set; } // SAL_SUB_TOT
        public decimal? SalTotCost { get; set; } // SAL_TOT_COST
        public int? SalLins { get; set; } // SAL_LINS
        public int? RetLins { get; set; } // RET_LINS
    }

}
// </auto-generated>