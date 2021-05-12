// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_DM_FORCST_LOC_ITEM_MNTH
    public class ViDmForcstLocItemMnth
    {
        public int? MnthId { get; set; } // MNTH_ID
        public string LocId { get; set; } // LOC_ID (length: 10)
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public string Dim1Upr { get; set; } // DIM_1_UPR (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (length: 15)
        public decimal? SlsQty { get; set; } // SLS_QTY
        public decimal? RtnQty { get; set; } // RTN_QTY
        public decimal? AdjQty { get; set; } // ADJ_QTY
        public decimal? XferOutQty { get; set; } // XFER_OUT_QTY
        public decimal? XferInQty { get; set; } // XFER_IN_QTY
        public decimal? QxferOutQty { get; set; } // QXFER_OUT_QTY
        public decimal? QxferInQty { get; set; } // QXFER_IN_QTY
        public decimal? QassemQty { get; set; } // QASSEM_QTY
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public decimal? ForcLevel { get; set; } // FORC_LEVEL
        public decimal? ForcTrend { get; set; } // FORC_TREND
        public decimal? MnthIndx { get; set; } // MNTH_INDX
        public int? CutoffMnthId { get; set; } // CUTOFF_MNTH_ID
        public string UseTi { get; set; } // USE_TI (length: 1)
        public DateTime? ForcUpdOn { get; set; } // FORC_UPD_ON
    }

}
// </auto-generated>
