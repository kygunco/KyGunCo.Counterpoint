// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KyGunCo.Counterpoint.Sdk.Entities
{
    // PO_RECVR_LIN
    public class PoRecvrLin
    {
        public string RecvrNo { get; set; } = "[AUTO-ASSIGN]"; // RECVR_NO (Primary key) (length: 15)
        public int SeqNo { get; set; } // SEQ_NO (Primary key)
        public string PoNo { get; set; } // PO_NO (length: 20)
        public int? PoSeqNo { get; set; } // PO_SEQ_NO
        public string ItemNo { get; set; } // ITEM_NO (length: 20)
        public string VendNo { get; set; } // VEND_NO (length: 15)
        public string VendItemNo { get; set; } // VEND_ITEM_NO (length: 30)
        public string Descr { get; set; } // DESCR (length: 50)
        public string DescrUpr { get; set; } // DESCR_UPR (length: 50)
        public string ItemDescr { get; set; } // ITEM_DESCR (length: 50)
        public string ItemDescrUpr { get; set; } // ITEM_DESCR_UPR (length: 50)
        public string Selectd { get; set; } = "Y"; // SELECTD (length: 1)
        public decimal QtyRecvd { get; set; } // QTY_RECVD
        public string QtyUnit { get; set; } // QTY_UNIT (length: 15)
        public string QtyRecvdUnit { get; set; } = "0"; // QTY_RECVD_UNIT (length: 1)
        public decimal QtyRecvdNumer { get; set; } = 1m; // QTY_RECVD_NUMER
        public decimal QtyRecvdDenom { get; set; } = 1m; // QTY_RECVD_DENOM
        public decimal? NewQtyExpectd { get; set; } // NEW_QTY_EXPECTD
        public decimal? PrevQtyExpectd { get; set; } // PREV_QTY_EXPECTD
        public decimal RecvdCost { get; set; } // RECVD_COST
        public decimal RecvdExtCost { get; set; } // RECVD_EXT_COST
        public string CellDescr { get; set; } // CELL_DESCR (length: 50)
        public string IsSingleCell { get; set; } = "N"; // IS_SINGLE_CELL (length: 1)
        public string Dim1Upr { get; set; } // DIM_1_UPR (length: 15)
        public string Dim2Upr { get; set; } // DIM_2_UPR (length: 15)
        public string Dim3Upr { get; set; } // DIM_3_UPR (length: 15)
        public string SerNo { get; set; } // SER_NO (length: 30)
        public int? NoOfSersEntd { get; set; } // NO_OF_SERS_ENTD
        public string Commnt1 { get; set; } // COMMNT_1 (length: 50)
        public string Commnt2 { get; set; } // COMMNT_2 (length: 50)
        public string Commnt3 { get; set; } // COMMNT_3 (length: 50)
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
        public decimal? QtyRecvdInStkUnits { get; set; } // QTY_RECVD_IN_STK_UNITS
        public string PsOrdDescr { get; private set; } // PS_ORD_DESCR (length: 29)
        public long? PsDocId { get; set; } // PS_DOC_ID
        public decimal? NewPrc1 { get; set; } // NEW_PRC_1
        public Guid LinGuid { get; set; } // LIN_GUID
        public Guid? OrigPoDocGuid { get; set; } // ORIG_PO_DOC_GUID
        public Guid? OrigPoLinGuid { get; set; } // ORIG_PO_LIN_GUID
        public string UserStyle { get; set; } // USER_STYLE (length: 80)
        public string IsTxblNorm { get; set; } = "Y"; // IS_TXBL_NORM (length: 1)
        public string IsTxbl { get; set; } = "Y"; // IS_TXBL (length: 1)
        public string IsTxblChngd { get; private set; } // IS_TXBL_CHNGD (length: 1)
        public string TaxCategNorm { get; set; } // TAX_CATEG_NORM (length: 10)
        public string TaxCateg { get; set; } // TAX_CATEG (length: 10)
        public string TaxCategChngd { get; private set; } // TAX_CATEG_CHNGD (length: 1)
        public decimal RecvdNormTaxAmtAllocHome { get; set; } = 0m; // RECVD_NORM_TAX_AMT_ALLOC_HOME
        public decimal RecvdTaxAmtAllocHome { get; set; } = 0m; // RECVD_TAX_AMT_ALLOC_HOME
        public string RecvdLinDiscTyp { get; set; } = "A"; // RECVD_LIN_DISC_TYP (length: 1)
        public decimal RecvdLinDiscValue { get; set; } = 0m; // RECVD_LIN_DISC_VALUE
        public string ApplyDocDisc { get; set; } = "Y"; // APPLY_DOC_DISC (length: 1)
        public decimal RecvdGrossUnitCost { get; set; } // RECVD_GROSS_UNIT_COST
        public decimal RecvdGrossExtCost { get; set; } // RECVD_GROSS_EXT_COST
        public decimal RecvdLinDiscAmt { get; set; } = 0m; // RECVD_LIN_DISC_AMT
        public decimal? RecvdDiscntdExtCost { get; private set; } // RECVD_DISCNTD_EXT_COST
        public decimal RecvdDocDiscAmt { get; set; } = 0m; // RECVD_DOC_DISC_AMT
        public string NewPrc1UsrId { get; set; } // NEW_PRC_1_USR_ID (length: 10)

        // Reverse navigation

        /// <summary>
        /// Child PoRecvrCells where [PO_RECVR_CELL].([RECVR_NO], [SEQ_NO]) point to this entity (FK_PO_RECVR_CELL_PO_RECVR_LIN)
        /// </summary>
        public virtual IList<PoRecvrCell> PoRecvrCells { get; set; } = new List<PoRecvrCell>(); // PO_RECVR_CELL.FK_PO_RECVR_CELL_PO_RECVR_LIN

        /// <summary>
        /// Child PoRecvrLinLocs where [PO_RECVR_LIN_LOC].([RECVR_NO], [SEQ_NO]) point to this entity (FK_PO_RECVR_LIN_LOC_PO_RECVR_LIN)
        /// </summary>
        public virtual IList<PoRecvrLinLoc> PoRecvrLinLocs { get; set; } = new List<PoRecvrLinLoc>(); // PO_RECVR_LIN_LOC.FK_PO_RECVR_LIN_LOC_PO_RECVR_LIN

        /// <summary>
        /// Child PoRecvrSers where [PO_RECVR_SER].([RECVR_NO], [SEQ_NO]) point to this entity (FK_PO_RECVR_SER_PO_RECVR_LIN)
        /// </summary>
        public virtual IList<PoRecvrSer> PoRecvrSers { get; set; } = new List<PoRecvrSer>(); // PO_RECVR_SER.FK_PO_RECVR_SER_PO_RECVR_LIN

        // Foreign keys

        /// <summary>
        /// Parent PoRecvrHdr pointed by [PO_RECVR_LIN].([RecvrNo]) (FK_PO_RECVR_LIN_PO_RECVR_HDR)
        /// </summary>
        public virtual PoRecvrHdr PoRecvrHdr { get; set; } // FK_PO_RECVR_LIN_PO_RECVR_HDR
    }

}
// </auto-generated>
