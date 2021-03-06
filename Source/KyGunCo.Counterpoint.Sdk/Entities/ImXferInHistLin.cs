// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_XFER_IN_HIST_LIN
    public class ImXferInHistLin
    {
        public string XferNo { get; set; } // XFER_NO (Primary key) (length: 15)
        public string EventNo { get; set; } // EVENT_NO (Primary key) (length: 15)
        public int XferInLinSeqNo { get; set; } // XFER_IN_LIN_SEQ_NO (Primary key)
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public int? XferLinSeqNo { get; set; } // XFER_LIN_SEQ_NO
        public string ItemDescr { get; set; } // ITEM_DESCR (length: 50)
        public string ItemDescrUpr { get; set; } // ITEM_DESCR_UPR (length: 50)
        public decimal? PrevQtyExpectd { get; set; } // PREV_QTY_EXPECTD
        public decimal? QtyRecvd { get; set; } // QTY_RECVD
        public decimal NewQtyExpectd { get; set; } // NEW_QTY_EXPECTD
        public string XferUnit { get; set; } // XFER_UNIT (length: 15)
        public string XferQtyUnit { get; set; } = "0"; // XFER_QTY_UNIT (length: 1)
        public decimal XferQtyNumer { get; set; } = 1m; // XFER_QTY_NUMER
        public decimal XferQtyDenom { get; set; } = 1m; // XFER_QTY_DENOM
        public string Commnt1 { get; set; } // COMMNT_1 (length: 50)
        public string Commnt2 { get; set; } // COMMNT_2 (length: 50)
        public string Commnt3 { get; set; } // COMMNT_3 (length: 50)
        public string CellDescr { get; set; } // CELL_DESCR (length: 50)
        public string IsSingleCell { get; set; } = "N"; // IS_SINGLE_CELL (length: 1)
        public string Dim1Upr { get; set; } // DIM_1_UPR (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (length: 15)
        public int? NoOfSersRecvd { get; set; } // NO_OF_SERS_RECVD
        public string SerNo { get; set; } // SER_NO (length: 30)
        public string ItemTyp { get; set; } = "I"; // ITEM_TYP (length: 1)
        public string TrkMeth { get; set; } = "N"; // TRK_METH (length: 1)
        public string CategCod { get; set; } // CATEG_COD (length: 10)
        public string SubcatCod { get; set; } // SUBCAT_COD (length: 10)
        public string ItemVendNo { get; set; } // ITEM_VEND_NO (length: 15)
        public decimal? ToQohBefore { get; set; } // TO_QOH_BEFORE
        public decimal? ToAvgCostBefore { get; set; } // TO_AVG_COST_BEFORE
        public decimal? ToAvgCostAfter { get; set; } // TO_AVG_COST_AFTER
        public decimal? ToStdCost { get; set; } = 0m; // TO_STD_COST
        public decimal? ToExtCost { get; set; } // TO_EXT_COST
        public decimal? ToTotCostCorr { get; set; } // TO_TOT_COST_CORR
        public decimal? ToUnitRetlVal { get; set; } // TO_UNIT_RETL_VAL
        public decimal? ToUnitCost { get; set; } // TO_UNIT_COST
        public decimal? XferInLinMiscAmt { get; set; } // XFER_IN_LIN_MISC_AMT
        public decimal? XferOutLinMiscAmt { get; set; } // XFER_OUT_LIN_MISC_AMT
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string AddedDuringEnt { get; set; } // ADDED_DURING_ENT (length: 1)

        // Reverse navigation

        /// <summary>
        /// Child ImXferInHistCells where [IM_XFER_IN_HIST_CELL].([EVENT_NO], [XFER_IN_LIN_SEQ_NO], [XFER_NO]) point to this entity (FK_IM_XFER_IN_HIST_CELL_IM_XFER_IN_HIST_LIN)
        /// </summary>
        public virtual IList<ImXferInHistCell> ImXferInHistCells { get; set; } = new List<ImXferInHistCell>(); // IM_XFER_IN_HIST_CELL.FK_IM_XFER_IN_HIST_CELL_IM_XFER_IN_HIST_LIN

        /// <summary>
        /// Child ImXferInHistSers where [IM_XFER_IN_HIST_SER].([EVENT_NO], [XFER_IN_LIN_SEQ_NO], [XFER_NO]) point to this entity (FK_IM_XFER_IN_HIST_SER_IM_XFER_IN_HIST_LIN)
        /// </summary>
        public virtual IList<ImXferInHistSer> ImXferInHistSers { get; set; } = new List<ImXferInHistSer>(); // IM_XFER_IN_HIST_SER.FK_IM_XFER_IN_HIST_SER_IM_XFER_IN_HIST_LIN

        // Foreign keys

        /// <summary>
        /// Parent ImXferInHist pointed by [IM_XFER_IN_HIST_LIN].([EventNo], [XferNo]) (FK_IM_XFER_IN_HIST_LIN_IM_XFER_IN_HIST)
        /// </summary>
        public virtual ImXferInHist ImXferInHist { get; set; } // FK_IM_XFER_IN_HIST_LIN_IM_XFER_IN_HIST
    }

}
// </auto-generated>
