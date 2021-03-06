// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PO_ADJ_HIST_LIN
    public class PoAdjHistLin
    {
        public string EventNo { get; set; } // EVENT_NO (Primary key) (length: 15)
        public string RecvrNo { get; set; } // RECVR_NO (Primary key) (length: 15)
        public int SeqNo { get; set; } // SEQ_NO (Primary key)
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public string VendNo { get; set; } // VEND_NO (length: 15)
        public string VendItemNo { get; set; } // VEND_ITEM_NO (length: 30)
        public string Descr { get; set; } // DESCR (length: 50)
        public string DescrUpr { get; set; } // DESCR_UPR (length: 50)
        public string ItemDescr { get; set; } // ITEM_DESCR (length: 50)
        public string ItemDescrUpr { get; set; } // ITEM_DESCR_UPR (length: 50)
        public decimal QtyRecvd { get; set; } // QTY_RECVD
        public string QtyUnit { get; set; } // QTY_UNIT (length: 15)
        public string QtyRecvdUnit { get; set; } = "0"; // QTY_RECVD_UNIT (length: 1)
        public decimal QtyRecvdNumer { get; set; } = 1m; // QTY_RECVD_NUMER
        public decimal QtyRecvdDenom { get; set; } = 1m; // QTY_RECVD_DENOM
        public decimal PrevRecvdCost { get; set; } // PREV_RECVD_COST
        public decimal PrevRecvdExtCost { get; set; } // PREV_RECVD_EXT_COST
        public decimal AdjRecvdCost { get; set; } // ADJ_RECVD_COST
        public decimal AdjRecvdExtCost { get; set; } // ADJ_RECVD_EXT_COST
        public decimal PrevLinMiscChrg1 { get; set; } // PREV_LIN_MISC_CHRG_1
        public decimal PrevLinMiscChrg2 { get; set; } // PREV_LIN_MISC_CHRG_2
        public decimal PrevLinMiscChrg3 { get; set; } // PREV_LIN_MISC_CHRG_3
        public decimal PrevLinMiscChrg4 { get; set; } // PREV_LIN_MISC_CHRG_4
        public decimal PrevLinMiscChrg5 { get; set; } // PREV_LIN_MISC_CHRG_5
        public decimal? PrevTotLinMiscChrg { get; set; } // PREV_TOT_LIN_MISC_CHRG
        public decimal AdjLinMiscChrg1 { get; set; } // ADJ_LIN_MISC_CHRG_1
        public decimal AdjLinMiscChrg2 { get; set; } // ADJ_LIN_MISC_CHRG_2
        public decimal AdjLinMiscChrg3 { get; set; } // ADJ_LIN_MISC_CHRG_3
        public decimal AdjLinMiscChrg4 { get; set; } // ADJ_LIN_MISC_CHRG_4
        public decimal AdjLinMiscChrg5 { get; set; } // ADJ_LIN_MISC_CHRG_5
        public decimal AdjTotLinMiscChrg { get; set; } // ADJ_TOT_LIN_MISC_CHRG
        public decimal PrevCost { get; set; } // PREV_COST
        public decimal PrevExtCost { get; set; } // PREV_EXT_COST
        public decimal AdjCost { get; set; } // ADJ_COST
        public decimal AdjExtCost { get; set; } // ADJ_EXT_COST
        public decimal QtyAdj { get; set; } // QTY_ADJ
        public decimal BsInvAdjAmt { get; set; } // BS_INV_ADJ_AMT
        public decimal? CogsAdjAmt { get; set; } // COGS_ADJ_AMT
        public decimal? MiscItemAdjAmt { get; set; } // MISC_ITEM_ADJ_AMT
        public decimal? AvgCostBefore { get; set; } // AVG_COST_BEFORE
        public decimal? AvgCostAfter { get; set; } // AVG_COST_AFTER
        public decimal? StdCost { get; set; } = 0m; // STD_COST
        public decimal? TotCostCorr { get; set; } // TOT_COST_CORR
        public string CellDescr { get; set; } // CELL_DESCR (length: 50)
        public string IsSingleCell { get; set; } = "N"; // IS_SINGLE_CELL (length: 1)
        public string Dim1Upr { get; set; } // DIM_1_UPR (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (length: 15)
        public string RecvAccruAcctNo { get; set; } // RECV_ACCRU_ACCT_NO (length: 20)
        public string Commnt1 { get; set; } // COMMNT_1 (length: 50)
        public string Commnt2 { get; set; } // COMMNT_2 (length: 50)
        public string Commnt3 { get; set; } // COMMNT_3 (length: 50)
        public string TrkMeth { get; set; } = "N"; // TRK_METH (length: 1)
        public string ItemVendNo { get; set; } // ITEM_VEND_NO (length: 15)
        public string CategCod { get; set; } // CATEG_COD (length: 10)
        public string ItemTyp { get; set; } = "I"; // ITEM_TYP (length: 1)
        public string SubcatCod { get; set; } // SUBCAT_COD (length: 10)
        public DateTime? AdjDat { get; set; } // ADJ_DAT
        public string RecvrLocId { get; set; } // RECVR_LOC_ID (length: 10)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public int? NoOfSersAdj { get; set; } // NO_OF_SERS_ADJ
        public decimal? UnitWeight { get; set; } // UNIT_WEIGHT
        public decimal? ExtWeight { get; set; } // EXT_WEIGHT
        public decimal? UnitCube { get; set; } // UNIT_CUBE
        public decimal? ExtCube { get; set; } // EXT_CUBE
        public decimal? QtyRecvdInStkUnits { get; set; } // QTY_RECVD_IN_STK_UNITS
        public string LinAdjMeth { get; set; } = "F"; // LIN_ADJ_METH (length: 1)
        public decimal PrevNormTaxAmtAllocHome { get; set; } = 0m; // PREV_NORM_TAX_AMT_ALLOC_HOME
        public decimal PrevTaxAmtAllocHome { get; set; } = 0m; // PREV_TAX_AMT_ALLOC_HOME
        public decimal AdjNormTaxAmtAllocHome { get; set; } = 0m; // ADJ_NORM_TAX_AMT_ALLOC_HOME
        public decimal AdjTaxAmtAllocHome { get; set; } = 0m; // ADJ_TAX_AMT_ALLOC_HOME
        public Guid LinGuid { get; set; } // LIN_GUID

        // Reverse navigation

        /// <summary>
        /// Child PoAdjHistCells where [PO_ADJ_HIST_CELL].([EVENT_NO], [RECVR_NO], [SEQ_NO]) point to this entity (FK_PO_ADJ_HIST_CELL_PO_ADJ_HIST_LIN)
        /// </summary>
        public virtual IList<PoAdjHistCell> PoAdjHistCells { get; set; } = new List<PoAdjHistCell>(); // PO_ADJ_HIST_CELL.FK_PO_ADJ_HIST_CELL_PO_ADJ_HIST_LIN

        /// <summary>
        /// Child PoAdjHistLinLocs where [PO_ADJ_HIST_LIN_LOC].([EVENT_NO], [RECVR_NO], [SEQ_NO]) point to this entity (FK_PO_ADJ_HIST_LIN_LOC_PO_ADJ_HIST_LIN)
        /// </summary>
        public virtual IList<PoAdjHistLinLoc> PoAdjHistLinLocs { get; set; } = new List<PoAdjHistLinLoc>(); // PO_ADJ_HIST_LIN_LOC.FK_PO_ADJ_HIST_LIN_LOC_PO_ADJ_HIST_LIN

        /// <summary>
        /// Child PoAdjHistSers where [PO_ADJ_HIST_SER].([EVENT_NO], [RECVR_NO], [SEQ_NO]) point to this entity (FK_PO_ADJ_HIST_SER_PO_ADJ_HIST_LIN)
        /// </summary>
        public virtual IList<PoAdjHistSer> PoAdjHistSers { get; set; } = new List<PoAdjHistSer>(); // PO_ADJ_HIST_SER.FK_PO_ADJ_HIST_SER_PO_ADJ_HIST_LIN

        // Foreign keys

        /// <summary>
        /// Parent PoAdjHist pointed by [PO_ADJ_HIST_LIN].([EventNo], [RecvrNo]) (FK_PO_ADJ_HIST_LIN_PO_ADJ_HIST)
        /// </summary>
        public virtual PoAdjHist PoAdjHist { get; set; } // FK_PO_ADJ_HIST_LIN_PO_ADJ_HIST
    }

}
// </auto-generated>
