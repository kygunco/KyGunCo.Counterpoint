// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PO_ORD_LIN
    public class PoOrdLin
    {
        public string PoNo { get; set; } // PO_NO (Primary key) (length: 20)
        public int SeqNo { get; set; } // SEQ_NO (Primary key)
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public string VendNo { get; set; } // VEND_NO (length: 15)
        public string VendItemNo { get; set; } // VEND_ITEM_NO (length: 30)
        public decimal OrdQty { get; set; } // ORD_QTY
        public string OrdUnit { get; set; } // ORD_UNIT (length: 15)
        public string OrdQtyUnit { get; set; } = "0"; // ORD_QTY_UNIT (length: 1)
        public decimal OrdQtyNumer { get; set; } = 1m; // ORD_QTY_NUMER
        public decimal OrdQtyDenom { get; set; } = 1m; // ORD_QTY_DENOM
        public DateTime? DelivDat { get; set; } // DELIV_DAT
        public DateTime? CancelDat { get; set; } // CANCEL_DAT
        public string Descr { get; set; } // DESCR (length: 50)
        public string DescrUpr { get; set; } // DESCR_UPR (length: 50)
        public string ItemDescr { get; set; } // ITEM_DESCR (length: 50)
        public string ItemDescrUpr { get; set; } // ITEM_DESCR_UPR (length: 50)
        public decimal OrdCost { get; set; } // ORD_COST
        public decimal OrdExtCost { get; set; } = 0m; // ORD_EXT_COST
        public string Commnt1 { get; set; } // COMMNT_1 (length: 50)
        public string Commnt2 { get; set; } // COMMNT_2 (length: 50)
        public string Commnt3 { get; set; } // COMMNT_3 (length: 50)
        public decimal QtyRecvd { get; set; } = 0m; // QTY_RECVD
        public decimal QtyExpectd { get; set; } // QTY_EXPECTD
        public string CellDescr { get; set; } // CELL_DESCR (length: 50)
        public string IsSingleCell { get; set; } = "N"; // IS_SINGLE_CELL (length: 1)
        public string Dim1Upr { get; set; } // DIM_1_UPR (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (length: 15)
        public DateTime? LstMaintDt { get; set; } // LST_MAINT_DT
        public string LstMaintUsrId { get; set; } // LST_MAINT_USR_ID (length: 10)
        public DateTime? LstLckDt { get; set; } // LST_LCK_DT
        public byte[] RowTs { get; set; } // ROW_TS
        public string PsOrdStrId { get; set; } // PS_ORD_STR_ID (length: 10)
        public string PsOrdStaId { get; set; } // PS_ORD_STA_ID (length: 10)
        public string PsOrdTktNo { get; set; } // PS_ORD_TKT_NO (length: 15)
        public decimal? UnitWeight { get; set; } // UNIT_WEIGHT
        public decimal? ExtWeight { get; set; } // EXT_WEIGHT
        public decimal? UnitCube { get; set; } // UNIT_CUBE
        public decimal? ExtCube { get; set; } // EXT_CUBE
        public decimal? QtyInStkUnits { get; set; } // QTY_IN_STK_UNITS
        public string PsOrdDescr { get; private set; } // PS_ORD_DESCR (length: 29)
        public long? PsDocId { get; set; } // PS_DOC_ID
        public DateTime? PsBusDat { get; set; } // PS_BUS_DAT
        public Guid LinGuid { get; set; } // LIN_GUID
        public string UserStyle { get; set; } // USER_STYLE (length: 80)
        public string IsTxblNorm { get; set; } = "Y"; // IS_TXBL_NORM (length: 1)
        public string IsTxbl { get; set; } = "Y"; // IS_TXBL (length: 1)
        public string IsTxblChngd { get; private set; } // IS_TXBL_CHNGD (length: 1)
        public string TaxCategNorm { get; set; } // TAX_CATEG_NORM (length: 10)
        public string TaxCateg { get; set; } // TAX_CATEG (length: 10)
        public string TaxCategChngd { get; private set; } // TAX_CATEG_CHNGD (length: 1)
        public decimal OrdNormTaxAmtAllocHome { get; set; } = 0m; // ORD_NORM_TAX_AMT_ALLOC_HOME
        public decimal OrdTaxAmtAllocHome { get; set; } = 0m; // ORD_TAX_AMT_ALLOC_HOME

        // Reverse navigation

        /// <summary>
        /// Child PoOrdCells where [PO_ORD_CELL].([PO_NO], [SEQ_NO]) point to this entity (FK_PO_ORD_CELL_PO_ORD_LIN)
        /// </summary>
        public virtual IList<PoOrdCell> PoOrdCells { get; set; } = new List<PoOrdCell>(); // PO_ORD_CELL.FK_PO_ORD_CELL_PO_ORD_LIN

        /// <summary>
        /// Child PoOrdLinLocs where [PO_ORD_LIN_LOC].([PO_NO], [SEQ_NO]) point to this entity (FK_PO_ORD_LIN_LOC_PO_ORD_LIN)
        /// </summary>
        public virtual IList<PoOrdLinLoc> PoOrdLinLocs { get; set; } = new List<PoOrdLinLoc>(); // PO_ORD_LIN_LOC.FK_PO_ORD_LIN_LOC_PO_ORD_LIN

        // Foreign keys

        /// <summary>
        /// Parent PoOrdHdr pointed by [PO_ORD_LIN].([PoNo]) (FK_PO_ORD_LIN_PO_ORD_HDR)
        /// </summary>
        public virtual PoOrdHdr PoOrdHdr { get; set; } // FK_PO_ORD_LIN_PO_ORD_HDR
    }

}
// </auto-generated>