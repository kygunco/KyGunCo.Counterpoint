// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_QXFER_HIST
    public class ImQxferHist
    {
        public string EventNo { get; set; } // EVENT_NO (Primary key) (length: 15)
        public string BatId { get; set; } // BAT_ID (Primary key) (length: 10)
        public string ItemNo { get; set; } // ITEM_NO (Primary key) (length: 20)
        public string FromLocId { get; set; } // FROM_LOC_ID (Primary key) (length: 10)
        public string ToLocId { get; set; } // TO_LOC_ID (Primary key) (length: 10)
        public DateTime TrxDat { get; set; } = DateTime.Now; // TRX_DAT (Primary key)
        public int SeqNo { get; set; } = 1; // SEQ_NO (Primary key)
        public decimal Qty { get; set; } // QTY
        public string QtyUnit { get; set; } = "0"; // QTY_UNIT (length: 1)
        public decimal QtyNumer { get; set; } = 1m; // QTY_NUMER
        public decimal QtyDenom { get; set; } = 1m; // QTY_DENOM
        public string Unit { get; set; } // UNIT (length: 15)
        public decimal MiscChrgAmt { get; set; } = 0m; // MISC_CHRG_AMT
        public string DocNo { get; set; } // DOC_NO (length: 15)
        public string Ref { get; set; } // REF (length: 50)
        public string Descr { get; set; } // DESCR (length: 30)
        public string ItemTyp { get; set; } = "I"; // ITEM_TYP (length: 1)
        public string TrkMeth { get; set; } = "N"; // TRK_METH (length: 1)
        public string CategCod { get; set; } // CATEG_COD (length: 10)
        public string SubcatCod { get; set; } // SUBCAT_COD (length: 10)
        public string ItemVendNo { get; set; } // ITEM_VEND_NO (length: 15)
        public decimal FromQohBefore { get; set; } = 0m; // FROM_QOH_BEFORE
        public decimal FromAvgCostBefore { get; set; } = 0m; // FROM_AVG_COST_BEFORE
        public decimal FromAvgCostAfter { get; set; } = 0m; // FROM_AVG_COST_AFTER
        public decimal FromStdCost { get; set; } = 0m; // FROM_STD_COST
        public decimal FromExtCost { get; set; } = 0m; // FROM_EXT_COST
        public decimal FromTotCostCorr { get; set; } = 0m; // FROM_TOT_COST_CORR
        public decimal FromUnitRetlVal { get; set; } = 0m; // FROM_UNIT_RETL_VAL
        public decimal FromCost { get; set; } = 0m; // FROM_COST
        public decimal ToQohBefore { get; set; } = 0m; // TO_QOH_BEFORE
        public decimal ToAvgCostBefore { get; set; } = 0m; // TO_AVG_COST_BEFORE
        public decimal ToAvgCostAfter { get; set; } = 0m; // TO_AVG_COST_AFTER
        public decimal ToStdCost { get; set; } = 0m; // TO_STD_COST
        public decimal ToExtCost { get; set; } = 0m; // TO_EXT_COST
        public decimal ToTotCostCorr { get; set; } = 0m; // TO_TOT_COST_CORR
        public decimal ToUnitRetlVal { get; set; } = 0m; // TO_UNIT_RETL_VAL
        public decimal ToCost { get; set; } = 0m; // TO_COST
        public string CellDescr { get; set; } // CELL_DESCR (length: 50)
        public string IsSingleCell { get; set; } = "N"; // IS_SINGLE_CELL (length: 1)
        public string Dim1Upr { get; set; } // DIM_1_UPR (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (length: 15)
        public string SerNo { get; set; } // SER_NO (length: 30)
        public int? NoOfSersEntd { get; set; } // NO_OF_SERS_ENTD
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS

        // Reverse navigation

        /// <summary>
        /// Child ImQxferHistCells where [IM_QXFER_HIST_CELL].([BAT_ID], [EVENT_NO], [FROM_LOC_ID], [ITEM_NO], [SEQ_NO], [TO_LOC_ID], [TRX_DAT]) point to this entity (FK_IM_QXFER_HIST_CELL_IM_QXFER_HIST)
        /// </summary>
        public virtual IList<ImQxferHistCell> ImQxferHistCells { get; set; } = new List<ImQxferHistCell>(); // IM_QXFER_HIST_CELL.FK_IM_QXFER_HIST_CELL_IM_QXFER_HIST

        /// <summary>
        /// Child ImQxferHistSers where [IM_QXFER_HIST_SER].([BAT_ID], [EVENT_NO], [FROM_LOC_ID], [ITEM_NO], [SEQ_NO], [TO_LOC_ID], [TRX_DAT]) point to this entity (FK_IM_QXFER_HIST_SER_IM_QXFER_HIST)
        /// </summary>
        public virtual IList<ImQxferHistSer> ImQxferHistSers { get; set; } = new List<ImQxferHistSer>(); // IM_QXFER_HIST_SER.FK_IM_QXFER_HIST_SER_IM_QXFER_HIST

        // Foreign keys

        /// <summary>
        /// Parent ImLocHist pointed by [IM_QXFER_HIST].([FromLocId]) (FK_IM_QXFER_HIST_IM_LOC_HIST)
        /// </summary>
        public virtual ImLocHist ImLocHist { get; set; } // FK_IM_QXFER_HIST_IM_LOC_HIST
    }

}
// </auto-generated>
