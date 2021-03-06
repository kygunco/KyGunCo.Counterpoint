// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // DM_FORCST_MNTH_CACHE
    public class DmForcstMnthCache
    {
        public int MnthId { get; set; } // MNTH_ID (Primary key)
        public string LocId { get; set; } // LOC_ID (Primary key) (length: 10)
        public string ItemNo { get; set; } // ITEM_NO (Primary key) (length: 20)
        public string Dim1Upr { get; set; } // DIM_1_UPR (Primary key) (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (Primary key) (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (Primary key) (length: 15)
        public decimal? ForcLevel { get; set; } // FORC_LEVEL
        public decimal? ForcTrend { get; set; } // FORC_TREND
        public decimal? MnthIndx { get; set; } // MNTH_INDX
        public int? CutoffMnthId { get; set; } // CUTOFF_MNTH_ID
        public string UseTi { get; set; } = "Y"; // USE_TI (length: 1)
        public DateTime? ForcUpdOn { get; set; } // FORC_UPD_ON
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT

        // Foreign keys

        /// <summary>
        /// Parent DmLocHist pointed by [DM_FORCST_MNTH_CACHE].([LocId]) (FK_DM_FORCST_MNTH_CACHE_DM_LOC_HIST)
        /// </summary>
        public virtual DmLocHist DmLocHist { get; set; } // FK_DM_FORCST_MNTH_CACHE_DM_LOC_HIST
    }

}
// </auto-generated>
