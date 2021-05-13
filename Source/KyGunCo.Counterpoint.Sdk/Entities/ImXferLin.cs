// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // IM_XFER_LIN
    public class ImXferLin
    {
        public string XferNo { get; set; } // XFER_NO (Primary key) (length: 15)
        public int XferLinSeqNo { get; set; } // XFER_LIN_SEQ_NO (Primary key)
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public string ItemDescr { get; set; } // ITEM_DESCR (length: 50)
        public string ItemDescrUpr { get; set; } // ITEM_DESCR_UPR (length: 50)
        public decimal XferQty { get; set; } // XFER_QTY
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
        public int? NoOfSersEntd { get; set; } // NO_OF_SERS_ENTD
        public string SerNo { get; set; } // SER_NO (length: 30)
        public string LinStat { get; set; } = "O"; // LIN_STAT (length: 1)
        public string ReconStat { get; set; } = "!"; // RECON_STAT (length: 1)
        public string CategCod { get; set; } // CATEG_COD (length: 10)
        public string SubcatCod { get; set; } // SUBCAT_COD (length: 10)
        public string ItemVendNo { get; set; } // ITEM_VEND_NO (length: 15)
        public string ItemTyp { get; set; } = "I"; // ITEM_TYP (length: 1)
        public string TrkMeth { get; set; } = "N"; // TRK_METH (length: 1)
        public decimal? FromQohBefore { get; set; } // FROM_QOH_BEFORE
        public decimal? FromAvgCostBefore { get; set; } // FROM_AVG_COST_BEFORE
        public decimal? FromAvgCostAfter { get; set; } // FROM_AVG_COST_AFTER
        public decimal? FromStdCost { get; set; } = 0m; // FROM_STD_COST
        public decimal? FromUnitCost { get; set; } // FROM_UNIT_COST
        public decimal? FromExtCost { get; set; } // FROM_EXT_COST
        public decimal? FromTotCostCorr { get; set; } // FROM_TOT_COST_CORR
        public decimal? FromUnitRetlVal { get; set; } // FROM_UNIT_RETL_VAL
        public decimal? XferOutLinMiscAmt { get; set; } // XFER_OUT_LIN_MISC_AMT
        public decimal? QtyRecvd { get; set; } // QTY_RECVD
        public decimal QtyExpectd { get; set; } // QTY_EXPECTD
        public decimal XferClrAcctBal { get; set; } // XFER_CLR_ACCT_BAL
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string AddedOnXferIn { get; private set; } // ADDED_ON_XFER_IN (length: 1)

        // Reverse navigation

        /// <summary>
        /// Child ImXferCells where [IM_XFER_CELL].([XFER_LIN_SEQ_NO], [XFER_NO]) point to this entity (FK_IM_XFER_CELL_IM_XFER_LIN)
        /// </summary>
        public virtual IList<ImXferCell> ImXferCells { get; set; } = new List<ImXferCell>(); // IM_XFER_CELL.FK_IM_XFER_CELL_IM_XFER_LIN

        /// <summary>
        /// Child ImXferSers where [IM_XFER_SER].([XFER_LIN_SEQ_NO], [XFER_NO]) point to this entity (FK_IM_XFER_SER_IM_XFER_LIN)
        /// </summary>
        public virtual IList<ImXferSer> ImXferSers { get; set; } = new List<ImXferSer>(); // IM_XFER_SER.FK_IM_XFER_SER_IM_XFER_LIN

        // Foreign keys

        /// <summary>
        /// Parent ImXferHdr pointed by [IM_XFER_LIN].([XferNo]) (FK_IM_XFER_LIN_IM_XFER_HDR)
        /// </summary>
        public virtual ImXferHdr ImXferHdr { get; set; } // FK_IM_XFER_LIN_IM_XFER_HDR
    }

}
// </auto-generated>