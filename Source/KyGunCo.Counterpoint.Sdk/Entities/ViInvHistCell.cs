// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // VI_INV_HIST_CELL
    public class ViInvHistCell
    {
        public string Type { get; set; } // TYPE (length: 1)
        public string FullType { get; set; } // FULL_TYPE (length: 1)
        public string EventNo { get; set; } // EVENT_NO (length: 15)
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public string Dim1Upr { get; set; } // DIM_1_UPR (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (length: 15)
        public string LocId { get; set; } // LOC_ID (length: 10)
        public decimal? Qty { get; set; } // QTY
        public DateTime? TrxDat { get; set; } // TRX_DAT
        public decimal? ExtCost { get; set; } // EXT_COST
        public decimal? ExtRet { get; set; } // EXT_RET
        public decimal? TotCostCorr { get; set; } // TOT_COST_CORR
        public decimal? ExtPrc { get; set; } // EXT_PRC
        public string DocNo { get; set; } // DOC_NO (length: 15)
        public string Descr { get; set; } // DESCR (length: 50)
        public string CategCod { get; set; } // CATEG_COD (length: 10)
        public string SubcatCod { get; set; } // SUBCAT_COD (length: 10)
        public string ItemVendNo { get; set; } // ITEM_VEND_NO (length: 15)
        public string OthrLoc { get; set; } // OTHR_LOC (length: 10)
        public decimal? UnitRetl { get; set; } // UNIT_RETL
        public decimal? UnitRegPrc { get; set; } // UNIT_REG_PRC
        public decimal? UnitCalcPrc { get; set; } // UNIT_CALC_PRC
        public decimal? UnitPrc { get; set; } // UNIT_PRC
        public decimal? UnitPrc1 { get; set; } // UNIT_PRC_1
        public decimal? UnitCost { get; set; } // UNIT_COST
    }

}
// </auto-generated>
